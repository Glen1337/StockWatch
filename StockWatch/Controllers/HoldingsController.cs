using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockWatch.Data;
using StockWatch.Models;

namespace StockWatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoldingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HoldingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Holdings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Holding>>> GetHoldings()
        {
            //_context.Holdings[0].
            return await _context.Holdings.ToListAsync();
        }

        // GET: api/Holdings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Holding>> GetHolding(long id)
        {
            var holding = await _context.Holdings.FindAsync(id);

            if (holding == null)
            {
                return NotFound();
            }

            return holding;
        }

        // PUT: api/Holdings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHolding(long id, Holding holding)
        {
            if (id != holding.HoldingId)
            {
                return BadRequest();
            }

            _context.Entry(holding).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoldingExists(id))
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

        // POST: api/Holdings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Holding>> PostHolding(Holding holding)
        {
            _context.Holdings.Add(holding);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHolding", new { id = holding.HoldingId }, holding);
        }

        // DELETE: api/Holdings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Holding>> DeleteHolding(long id)
        {
            var holding = await _context.Holdings.FindAsync(id);
            if (holding == null)
            {
                return NotFound();
            }

            _context.Holdings.Remove(holding);
            await _context.SaveChangesAsync();

            return holding;
        }

        private bool HoldingExists(long id)
        {
            return _context.Holdings.Any(e => e.HoldingId == id);
        }
    }
}
