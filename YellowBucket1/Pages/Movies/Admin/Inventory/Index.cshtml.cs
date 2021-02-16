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
    public class InventoryIndexModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public InventoryIndexModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public IList<Inventories> Inventories { get;set; }
        public IList<Kiosks> Kiosks { get; set; }

        public async Task OnGetAsync()
        {
            Inventories = await _context.Inventories.ToListAsync();
            Kiosks = await _context.Kiosks.ToListAsync();
        }
    }
}
