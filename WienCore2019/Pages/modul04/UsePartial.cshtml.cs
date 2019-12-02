using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class UsePartialModel : PageModel
    {
        public void OnGet()
        {

        }
        public PartialViewResult OnPost()
        { 
            return Partial("_Zeit");
        }
        public PartialViewResult OnGetLade()
        {
            return Partial("_Zeit");
        }
    }
}