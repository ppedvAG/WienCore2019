using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class DetailsPageModel : PageModel
    {
        public int ID { get; set; }
        public void OnGet([FromRoute]int id)
        {
            ID = id;
        }
    }
}