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
    public class KioskDeleteModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public KioskDeleteModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kiosks Kiosks { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Kiosks = await _context.Kiosks.FirstOrDefaultAsync(m => m.ID == id);

            if (Kiosks == null)
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

            Kiosks = await _context.Kiosks.FindAsync(id);

            if (Kiosks != null)
            {
                _context.Kiosks.Remove(Kiosks);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
