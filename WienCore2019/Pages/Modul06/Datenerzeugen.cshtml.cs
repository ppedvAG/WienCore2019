using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class DatenerzeugenModel : PageModel
    {
       
        public void OnGet([FromServices]  ERPModel2 ef)
        {
            var r = new Rechnung() { Datum = DateTime.Now, KundenID = 1, Summe = 50 };
            r.Positionen.Add(new Positionen() { Anzahl = 1, Preis = 20, Text = "demo1" });
            r.Positionen.Add(new Positionen() { Anzahl = 1, Preis = 30, Text = "demo2" });
            ef.Rechnung.Add(r);
            ef.SaveChanges();

        }
    }
}