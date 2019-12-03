using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class BilderModel : PageModel
    {
        public List<string> Bilder { get; set; } = new List<string>();
        public void OnGet()
        {
            string[] str = { AppDomain.CurrentDomain.GetData("pfad").ToString(), "wwwroot", "upload" };
            var pfad = Path.Combine(str);
            foreach (var item in   Directory.GetFiles(pfad, "*.jpg"))
            {
                Bilder.Add(Path.GetFileName(item));
            }
          
        }
    }
}