using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proinz2020.Model;

namespace proinz2020.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryCodesController : ControllerBase
    {
        private readonly PSQLDbContext _context;

        public CountryCodesController(PSQLDbContext context)
        {
            _context = context;
        }

        // GET: api/CountryCodes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryCode>>> GetCountryCodes()
        {
            return await _context.CountryCodes.ToListAsync();
        }

        // GET: api/CountryCodes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryCode>> GetCountryCode(int id)
        {
            var countryCode = await _context.CountryCodes.FindAsync(id);

            if (countryCode == null)
            {
                return NotFound();
            }

            return countryCode;
        }

        // PUT: api/CountryCodes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountryCode(int id, CountryCode countryCode)
        {
            if (id != countryCode.Id)
            {
                return BadRequest();
            }

            _context.Entry(countryCode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryCodeExists(id))
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

        // POST: api/CountryCodes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CountryCode>> PostCountryCode(CountryCode countryCode)
        {
            _context.CountryCodes.Add(countryCode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCountryCode", new { id = countryCode.Id }, countryCode);
        }

        // DELETE: api/CountryCodes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CountryCode>> DeleteCountryCode(int id)
        {
            var countryCode = await _context.CountryCodes.FindAsync(id);
            if (countryCode == null)
            {
                return NotFound();
            }

            _context.CountryCodes.Remove(countryCode);
            await _context.SaveChangesAsync();

            return countryCode;
        }

        private bool CountryCodeExists(int id)
        {
            return _context.CountryCodes.Any(e => e.Id == id);
        }
    }
}
