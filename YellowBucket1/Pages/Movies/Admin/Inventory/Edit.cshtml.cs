using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using YellowBucket1.Data;
using YellowBucket1.Models;

namespace YellowBucket1
{
    public class InventoryEditModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public InventoryEditModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inventories = await _context.Inventories.Include(m => m.Movie).FirstOrDefaultAsync(m => m.ID == id);

            return Page();
        }

        [BindProperty]
        public Inventories Inventories { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Inventories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InventoriesExists(Inventories.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InventoriesExists(int id)
        {
            return _context.Inventories.Any(e => e.ID == id);
        }
    }
}
