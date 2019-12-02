using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class calc3Model : PageModel
    {
        public int Ergebnis { get; set; }
        public int eins { get; set; }
        public int zwei { get; set; }
        public void OnGet()
        {

        }
        public void OnPostPlus()
        {
            Ergebnis = eins + zwei;
        }
        public void OnPostMinus()
        {
            Ergebnis = eins - zwei;
        }
    }
}