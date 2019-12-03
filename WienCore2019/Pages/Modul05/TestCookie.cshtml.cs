using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class TestCookieModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnGetSetzKeks()
        {
            Response.Cookies.Append("temp", "Jammes");
            var fixCookie = new CookieOptions()
            {
                IsEssential = true,
                Expires = new DateTimeOffset(DateTime.Now.AddDays(30))

            };
            Response.Cookies.Append("dauerhaft", "Hannes", fixCookie);
        }
    }
}