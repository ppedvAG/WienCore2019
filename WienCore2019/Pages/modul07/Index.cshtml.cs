using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WienCore2019
{
    public class IndexModel : PageModel
    {
        private readonly WienCore2019.ERPModel2 _context;

        public IndexModel(WienCore2019.ERPModel2 context)
        {
            _context = context;
        }

        public IList<Rechnung> Rechnung { get;set; }

        public async Task OnGetAsync()
        {
            Rechnung = await _context.Rechnung.ToListAsync();
        }
    }
}
