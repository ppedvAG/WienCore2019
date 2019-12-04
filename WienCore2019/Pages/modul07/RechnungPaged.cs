using Microsoft.AspNetCore.Mvc;
using StuttgartCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WienCore2019;

namespace StuttgartCore.Pages.modul07
{
    public class RechnungPaged:ViewComponent
    {
        private ERPModel2 _db;
        public RechnungPaged(ERPModel2 db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke(int page=0)
        {
            List<Rechnung> model = _db.Rechnung.Skip(page * 3).Take(3).ToList();
            return View(model); //default.cshtml in views....
        }
    }
}
