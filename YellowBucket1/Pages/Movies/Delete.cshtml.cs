using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YellowBucket1.Data;
using YellowBucket1.Models;

namespace YellowBucket1.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public DeleteModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public YellowBucket1.Models.Movies Movies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.Include("MoviesGenres.Genres").FirstOrDefaultAsync(m => m.ID == id);

            if (Movies == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.FindAsync(id);

            if (Movies != null)
            {
                _context.Movies.Remove(Movies);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
