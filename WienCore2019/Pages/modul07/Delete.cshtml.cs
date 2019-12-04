using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WienCore2019
{
    public class DeleteModel : PageModel
    {
        private readonly WienCore2019.ERPModel2 _context;

        public DeleteModel(WienCore2019.ERPModel2 context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rechnung = await _context.Rechnung.FindAsync(id);

            if (Rechnung != null)
            {
                _context.Rechnung.Remove(Rechnung);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
