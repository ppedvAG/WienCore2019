using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class calc1Model : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnGet()
        {
            Ergebnis = 0;
        }
        public void OnPost()
        {
           int eins=Int32.Parse( HttpContext.Request.Form["eins"]);
            int zwei = Int32.Parse(HttpContext.Request.Form["zwei"]);
            Ergebnis = eins + zwei;
        }
    }
}