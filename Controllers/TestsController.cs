using AspTest.Data;
using AspTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TestsController : ControllerBase
    {
        private readonly AspTestDbContext _context;

        public TestsController(AspTestDbContext context)
        {
            _context = context;
        }

        // GET: api/Tests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tests>>> GetTests()
        {
            return await _context.Tests
                .Include(t => t.Options)
                .ToListAsync();
        }

        // GET: api/Tests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tests>> GetTests(int id)
        {
            var tests = await _context.Tests.FindAsync(id);

            if (tests == null)
            {
                return NotFound();
            }

            return tests;
        }

        // PUT: api/Tests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTests(int id, Tests tests)
        {
            if (id != tests.Id)
            {
                return BadRequest();
            }

            _context.Entry(tests).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestsExists(id))
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

        // POST: api/Tests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tests>> PostTests(Tests tests)
        {
            _context.Tests.Add(tests);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTests", new { id = tests.Id }, tests);
        }

        // DELETE: api/Tests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTests(int id)
        {
            var tests = await _context.Tests.FindAsync(id);
            if (tests == null)
            {
                return NotFound();
            }

            _context.Tests.Remove(tests);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestsExists(int id)
        {
            return _context.Tests.Any(e => e.Id == id);
        }
    }
}
