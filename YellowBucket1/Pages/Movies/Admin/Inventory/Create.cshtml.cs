using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YellowBucket1.Data;
using YellowBucket1.Models;

namespace YellowBucket1
{
    public class InventoryCreateModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public InventoryCreateModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

            _context.Inventories.Add(Inventories);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
