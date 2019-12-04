using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WienCore2019;

namespace WienCore2019.Pages.modul09
{
    [Route("api/[controller]")]
    [ApiController]
    public class RechnungsController : ControllerBase
    {
        private readonly ERPModel2 _context;

        public RechnungsController(ERPModel2 context)
        {
            _context = context;
        }

        // GET: api/Rechnungs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rechnung>>> GetRechnung()
        {
            return await _context.Rechnung.ToListAsync();
        }

        // GET: api/Rechnungs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rechnung>> GetRechnung(int id)
        {
            var rechnung = await _context.Rechnung.FindAsync(id);

            if (rechnung == null)
            {
                return NotFound();
            }

            return rechnung;
        }

        // PUT: api/Rechnungs/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRechnung(int id, Rechnung rechnung)
        {
            if (id != rechnung.Id)
            {
                return BadRequest();
            }

            _context.Entry(rechnung).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RechnungExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Rechnungs
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Rechnung>> PostRechnung(Rechnung rechnung)
        {
            _context.Rechnung.Add(rechnung);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRechnung", new { id = rechnung.Id }, rechnung);
        }

        // DELETE: api/Rechnungs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rechnung>> DeleteRechnung(int id)
        {
            var rechnung = await _context.Rechnung.FindAsync(id);
            if (rechnung == null)
            {
                return NotFound();
            }

            _context.Rechnung.Remove(rechnung);
            await _context.SaveChangesAsync();

            return rechnung;
        }

        private bool RechnungExists(int id)
        {
            return _context.Rechnung.Any(e => e.Id == id);
        }
    }
}
