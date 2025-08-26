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
    public class TestSessionsController : ControllerBase
    {
        private readonly AspTestDbContext _context;

        public TestSessionsController(AspTestDbContext context)
        {
            _context = context;
        }

        // GET: api/TestSessions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestSessions>>> GetTestSessions()
        {
            return await _context.TestSessions.ToListAsync();
        }

        // GET: api/TestSessions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestSessions>> GetTestSessions(int id)
        {
            var testSessions = await _context.TestSessions.FindAsync(id);

            if (testSessions == null)
            {
                return NotFound();
            }

            return testSessions;
        }

        // PUT: api/TestSessions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestSessions(int id, TestSessions testSessions)
        {
            if (id != testSessions.Id)
            {
                return BadRequest();
            }

            _context.Entry(testSessions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestSessionsExists(id))
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

        // POST: api/TestSessions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestSessions>> PostTestSessions(TestSessions testSessions)
        {
            _context.TestSessions.Add(testSessions);

            // Get 10 random or first 10 tests from the Tests table
            var tests = await _context.Tests
                .Where(t => t.IsActive)      // only active tests
                .Take(10)                    // take first 10 (or use OrderBy/random if you want)
                .ToListAsync();

            foreach (var test in tests)
            {
                testSessions.TestSessionTests.Add(new TestSessionTests
                {
                    TestId = test.Id,
                    TestSessionId = testSessions.Id
                });
            }

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestSessions", new { id = testSessions.Id }, testSessions);
        }

        // DELETE: api/TestSessions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestSessions(int id)
        {
            var testSessions = await _context.TestSessions.FindAsync(id);
            if (testSessions == null)
            {
                return NotFound();
            }

            _context.TestSessions.Remove(testSessions);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestSessionsExists(int id)
        {
            return _context.TestSessions.Any(e => e.Id == id);
        }
    }
}
