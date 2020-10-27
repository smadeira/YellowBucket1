using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using YellowBucket1.Data;
using YellowBucket1.Models;

namespace YellowBucket1.Pages.Movies.Rentals
{
    public class IndexModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public IndexModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public IList<YellowBucket1.Models.Movies> Movies { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

       
        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movies
                 select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            Movies = await movies.ToListAsync();
        }
    }
}