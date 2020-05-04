using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Loginform.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public string msg;
        public void OnGet()
        {

        } 
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("Username");
            return Page();
        }
        public IActionResult OnPost()
        {
            if (Username.Equals("abc") && Password.Equals("abc"))
            {
                HttpContext.Session.SetString("Username", Username);
                return RedirectToPage("Welcome");

            }
            else
            {
                msg = "Invalid";
                return Page();
            }

        }
    }
}