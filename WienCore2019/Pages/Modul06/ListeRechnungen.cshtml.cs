using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WienCore2019
{
    public class ListeRechnungenModel : PageModel
    {
        public List<Rechnung> Liste { get; set; }
        public void OnGet([FromServices]  ERPModel2 ef)
        {
            Liste = ef.Rechnung.Include("Positionen").ToList();
        }
    }
}