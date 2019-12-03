using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;

namespace WienCore2019
{
    [ResponseCache(Duration =10,VaryByHeader = "User-Agent")]
    public class TeilCacheModel : PageModel
    {
        IMemoryCache memoryCache;
        public TeilCacheModel(IMemoryCache _memoryCache)
        {
            memoryCache = _memoryCache;
        }
        public void OnGet()
        {
            memoryCache.Set("hannes", "Wert", new DateTimeOffset(DateTime.Now.AddDays(30)));
           
        }
    }
}