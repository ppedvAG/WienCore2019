using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WienCore2019
{
    public class BildUploadModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost(IFormFile datei)
        {
          string name=  Path.GetFileName(datei.FileName); //wegen Edge bzw Chrome unterschiede
            string[] str= { AppDomain.CurrentDomain.GetData("pfad").ToString(),"wwwroot", "upload", name };
            var pfad = Path.Combine(str );
    

            using (var fs = new FileStream(pfad, FileMode.Create))
            {
                datei.CopyTo(fs);
            }
        }


    }
}