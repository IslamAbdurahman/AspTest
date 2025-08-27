using AspTest.Data;
using AspTest.Dtos;
using AspTest.DTOs;
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


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestSessions>>> GetTestSessions()
        {
            return await _context.TestSessions.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TestSessionDto>> GetTestSessions(long id)
        {
            var testSession = await _context.TestSessions
                .Include(ts => ts.TestSessionTests)
                    .ThenInclude(tst => tst.Test)
                        .ThenInclude(t => t.Options)
                .FirstOrDefaultAsync(ts => ts.Id == id);

            if (testSession == null)
            {
                return NotFound();
            }


            var dto = new TestSessionDto
            {
                Id = testSession.Id,
                UserId = testSession.UserId,
                StartedAt = testSession.StartedAt,
                CompletedAt = testSession.CompletedAt,
                CorrectCount = testSession.CorrectCount,
                Minutes = testSession.Minutes,
                Status = testSession.Status,
                Tests = testSession.TestSessionTests.Select(tst => new TestDto
                {
                    Id = tst.Test.Id,
                    QuestionText = tst.Test.QuestionText,
                    IsActive = tst.Test.IsActive,
                    Options = tst.Test.Options.Select(o => new OptionDto
                    {
                        Id = o.Id,
                        OptionText = o.OptionText,
                        IsCorrect = o.IsCorrect
                    }).ToList()
                }).ToList()
            };

            return dto;
        }


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


        [HttpPost]
        public async Task<ActionResult<CreateTestSessionDto>> PostTestSessions(CreateTestSessionDto dto)
        {

            var entity = new TestSessions
            {
                UserId = dto.UserId,
                StartedAt = DateTime.Now,
                Minutes = 30
            };

            _context.TestSessions.Add(entity);
            await _context.SaveChangesAsync();


            var tests = await _context.Tests
                .Where(t => t.IsActive)
                .Take(10)
                .ToListAsync();

            foreach (var test in tests)
            {
                _context.TestSessionTests.Add(new TestSessionTests
                {
                    TestId = test.Id,
                    TestSessionId = entity.Id
                });
            }

            await _context.SaveChangesAsync();


            var resultDto = new TestSessionDto
            {
                Id = entity.Id,
                UserId = entity.UserId,
                StartedAt = entity.StartedAt,
                CompletedAt = entity.CompletedAt,
                CorrectCount = entity.CorrectCount,
                Minutes = entity.Minutes,
                Status = entity.Status
            };

            return CreatedAtAction("GetTestSessions", new { id = entity.Id }, resultDto);
        }


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
