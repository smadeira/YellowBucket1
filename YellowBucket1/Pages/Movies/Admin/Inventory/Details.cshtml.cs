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
    public class InventoryDetailsModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public InventoryDetailsModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public Inventories Inventories { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inventories = await _context.Inventories.FirstOrDefaultAsync(m => m.ID == id);

            if (Inventories == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
