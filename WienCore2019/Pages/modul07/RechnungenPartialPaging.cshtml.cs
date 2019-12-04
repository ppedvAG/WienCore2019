using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class RechnungenPartialPagingModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public int SeiteCounter { get; set; }
        public  List<Rechnung> Liste{ get; set; }
        public void OnGet()
        {

        }
        public PartialViewResult OnGetLadeNext([FromServices] ERPModel2 ef)
        {
            Liste=ef.Rechnung.Skip(SeiteCounter * 10).Take(10).ToList();
            return Partial("_RechnungenPartialPaging",this);
        }
    }
}