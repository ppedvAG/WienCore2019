using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WienCore2019
{
    public class CreateModel : PageModel
    {
        private readonly WienCore2019.ERPModel2 _context;

        public CreateModel(WienCore2019.ERPModel2 context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rechnung Rechnung { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rechnung.Add(Rechnung);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
