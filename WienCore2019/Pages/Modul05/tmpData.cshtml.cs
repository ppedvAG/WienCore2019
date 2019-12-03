using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class tmpDataModel : PageModel
    {
        public void OnGet()
        {
            var t = TempData["hannes"];
           // TempData.Peek("hannes");
        
        }
        public void OnPost([FromForm] string wert)
        {
            TempData["hannes"] = wert;
        }
    }
}