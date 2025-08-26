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
    public class TestSessionAnswersController : ControllerBase
    {
        private readonly AspTestDbContext _context;

        public TestSessionAnswersController(AspTestDbContext context)
        {
            _context = context;
        }

        // GET: api/TestSessionAnswers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestSessionAnswers>>> GetTestSessionAnswers()
        {
            return await _context.TestSessionAnswers.ToListAsync();
        }

        // GET: api/TestSessionAnswers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TestSessionAnswers>> GetTestSessionAnswers(int id)
        {
            var testSessionAnswers = await _context.TestSessionAnswers.FindAsync(id);

            if (testSessionAnswers == null)
            {
                return NotFound();
            }

            return testSessionAnswers;
        }

        // PUT: api/TestSessionAnswers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestSessionAnswers(int id, TestSessionAnswers testSessionAnswers)
        {
            if (id != testSessionAnswers.Id)
            {
                return BadRequest();
            }

            _context.Entry(testSessionAnswers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestSessionAnswersExists(id))
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

        // POST: api/TestSessionAnswers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TestSessionAnswers>> PostTestSessionAnswers(TestSessionAnswers testSessionAnswers)
        {
            _context.TestSessionAnswers.Add(testSessionAnswers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestSessionAnswers", new { id = testSessionAnswers.Id }, testSessionAnswers);
        }

        // DELETE: api/TestSessionAnswers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestSessionAnswers(int id)
        {
            var testSessionAnswers = await _context.TestSessionAnswers.FindAsync(id);
            if (testSessionAnswers == null)
            {
                return NotFound();
            }

            _context.TestSessionAnswers.Remove(testSessionAnswers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestSessionAnswersExists(int id)
        {
            return _context.TestSessionAnswers.Any(e => e.Id == id);
        }
    }
}
