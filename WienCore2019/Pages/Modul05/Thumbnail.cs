using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WienCore2019.Pages.Modul05
{
    public class Thumbnail
    {
        public Thumbnail(RequestDelegate _next)
        {

        }
        public async Task Invoke (HttpContext context)
        {
            var img = context.Request.Query["img"];
            string name = Path.GetFileName(img); //wegen Edge bzw Chrome unterschiede
            string[] str = { AppDomain.CurrentDomain.GetData("pfad").ToString(), "wwwroot", "upload", name };
            var pfad = Path.Combine(str);
            await context.Response.SendFileAsync(pfad);
        }
    }
}
