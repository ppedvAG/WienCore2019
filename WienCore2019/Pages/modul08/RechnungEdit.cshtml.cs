using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WienCore2019
{
    public class RechnungEditModel : PageModel
    {
        ERPModel2 _ef;
        public RechnungEditModel(ERPModel2 ef)
        {
            _ef = ef;
        }
        [BindProperty]
        public Rechnung Rechnung { get; set; }
        public ActionResult OnGet([FromRoute] int id)
        {
            Rechnung = _ef.Rechnung.Where(x => x.Id == id).FirstOrDefault();
            if (Rechnung ==null)
            {
                return NotFound();
            }
            return Page();
        }

        public ActionResult OnPost()
        {
            if (ModelState.IsValid==false)
            {
                return Page();
            }
            Rechnung.Id = int.Parse(RouteData.Values["id"].ToString());
            _ef.Rechnung.Attach(Rechnung).State = EntityState.Modified;
            _ef.SaveChanges();
            return Page();
        }
    }
}