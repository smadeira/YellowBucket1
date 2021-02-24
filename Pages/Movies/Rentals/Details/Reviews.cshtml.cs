using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YellowBucket1.Data;
using YellowBucket1.Models;

namespace YellowBucket1
{
    public class ReviewsModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public ReviewsModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movies.Include(m => m.CustomerReviews).Include("CustomerReviews.Customer").FirstOrDefaultAsync(m => m.ID == id);
            //Movie = await _context.CustomerReviews.Include(m => m.Customer).FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        [BindProperty]
        public CustomerReviews CustomerReviews { get; set; }
        public Models.Movies Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState["CustomerReviews.Customer"] != null) ModelState.Remove("CustomerReviews.Customer");
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CustomerReviews.Add(CustomerReviews);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Reviews",new { id = CustomerReviews.MoviesID });
        }
    }
}
