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
    public class IndexModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public IndexModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public IList<YellowBucket1.Models.Movies> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
