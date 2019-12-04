using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WienCore2019
{
    public class CollapseRechnungModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public List<Rechnung> Liste { get; set; }
        public void OnGet([FromServices]  ERPModel2 ef)
        {
            if (SearchString != null)
            {
                Liste = ef.Rechnung.Include("Positionen").Where(x => x.KundenID.ToString().Contains(SearchString)).ToList();
            }
            else
            {
                Liste = ef.Rechnung.Include("Positionen").ToList();
            }
        }
       
    }
}