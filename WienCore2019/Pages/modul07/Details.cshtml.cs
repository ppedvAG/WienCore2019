using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WienCore2019
{
    public class DetailsModel : PageModel
    {
        private readonly WienCore2019.ERPModel2 _context;

        public DetailsModel(WienCore2019.ERPModel2 context)
        {
            _context = context;
        }

        public Rechnung Rechnung { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rechnung = await _context.Rechnung.FirstOrDefaultAsync(m => m.Id == id);

            if (Rechnung == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
