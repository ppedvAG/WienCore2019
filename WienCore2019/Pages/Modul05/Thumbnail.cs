using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            //  Install-Package System.Drawing.Common

            Image image = Image.FromFile(pfad);
            Image thumb = image.GetThumbnailImage(300, 200, () => false, IntPtr.Zero);
           
            await context.Response.SendFileAsync(pfad);
           
           // await _next(context);
        }
    }
}
