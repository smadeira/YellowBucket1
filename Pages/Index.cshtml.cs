using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using YellowBucket1.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace YellowBucket1.Pages {
    public class IndexModel : PageModel {
        //private readonly ILogger<IndexModel> _logger;
        //public IndexModel(ILogger<IndexModel> logger) {
        //    _logger = logger;
        //}
        private readonly IConfiguration configuration;
        public IndexModel(IConfiguration configuration) {
            this.configuration = configuration;
        }

        [BindProperty]
        public string UserName { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        public string Message { get; set; }

        public async Task<IActionResult> OnPost() {
            var user = configuration.GetSection("SiteUser").Get<SiteUser>();

            if (UserName == user.UserName) {
                var passwordHasher = new PasswordHasher<string>();
                if(Password != null)
                    if (passwordHasher.VerifyHashedPassword(null, user.Password, Password) == PasswordVerificationResult.Success) {
                        var claims = new List<Claim> { new Claim(ClaimTypes.Name, UserName) };
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                        return RedirectToPage("/Movies/Admin/index");
                    }
            }
            Message = "Invalid attempt";
            return Page();
        }

        public void OnGet() {

        }
    }
}
