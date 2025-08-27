using AspTest.Data;
using AspTest.DTOs;
using AspTest.Models;
using Humanizer;
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


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tests>>> GetTests()
        {
            return await _context.Tests
                .Include(t => t.Options)
                .ToListAsync();
        }


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


        [HttpPost]
        public async Task<ActionResult<CreateTestDto>> PostTests(CreateTestDto tests)
        {
            var entity = new Tests
            {
                QuestionText = tests.QuestionText,
                IsActive = tests.IsActive,
                CreatedAt = DateTime.Now,
            };

            _context.Tests.Add(entity);
            await _context.SaveChangesAsync();

            // Saqlangandan keyin entity.Id mavjud bo‘ladi
            tests.Id = entity.Id;

            return CreatedAtAction(nameof(GetTests), new { id = entity.Id }, tests);
        }



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
