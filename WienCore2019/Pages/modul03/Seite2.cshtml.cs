using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WienCore2019.Modul02;
namespace WienCore2019
{
    public class Seite2Model : PageModel
    {
        public DI _DI { get; set; }
        public Seite2Model(DI hannes)
        {
            _DI =hannes;       
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {

        }
    }
}