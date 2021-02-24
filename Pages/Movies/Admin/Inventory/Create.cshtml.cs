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
    public class InventoriesCreateModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public InventoriesCreateModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            KioskID = id;
            Movies = await _context.Movies.ToListAsync();

            return Page();
        }

        [BindProperty]
        public Inventories Inventories { get; set; }
        public int KioskID { get; set; }
        public List<Movies> Movies { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Inventories.Add(Inventories);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
