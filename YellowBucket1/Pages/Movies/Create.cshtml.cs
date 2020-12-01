using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using YellowBucket1.Data;
using YellowBucket1.Models;

namespace YellowBucket1.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public CreateModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Genres = _context.Genres.ToList();
            
            return Page();
        }
        [BindProperty]
        public int GenresID { get; set; }

        [BindProperty]
        public YellowBucket1.Models.Movies Movies { get; set; }
        public List<Genres> Genres { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Movies.Add(Movies);
            await _context.SaveChangesAsync();
            Movies.MoviesGenres = new List<MoviesGenres>();
            Movies.MoviesGenres.Add(new MoviesGenres { MoviesID = Movies.ID, GenresID = GenresID });
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
