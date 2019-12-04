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
                        var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var r = new Rechnung() { Datum = DateTime.Now.AddDays(rand.Next(300)), KundenID = rand.Next(100000) };
                for (int ii = 0; ii < rand.Next(5); ii++)
                {
                    r.Positionen.Add(new Positionen() { Anzahl = rand.Next(3), Preis = rand.Next(99), Text = "demo"+rand.Next(10000).ToString() });
                }

                r.Summe = r.Positionen.Sum(x => x.Anzahl * x.Preis);
                ef.Rechnung.Add(r);
                ef.SaveChanges();
            }


        }
    }
}