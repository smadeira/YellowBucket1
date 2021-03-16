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
    public class UserIndexModel : PageModel
    {
        private readonly YellowBucket1.Data.MoviesContext _context;

        public UserIndexModel(YellowBucket1.Data.MoviesContext context)
        {
            _context = context;
        }

        public IList<Customers> Users { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UserSearch { get; set; }
        public async Task OnGetAsync()
        {
            var usersName = from m in _context.Customers
                         select m;
            if (!string.IsNullOrEmpty(UserSearch))
            {
                usersName = usersName.Where(c => c.LasttName.Contains(UserSearch));
            }
            Users = await usersName.ToListAsync();

        }
    }
}
