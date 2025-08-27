using AspTest.Data;
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
    public class OptionsController : ControllerBase
    {
        private readonly AspTestDbContext _context;

        public OptionsController(AspTestDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Options>>> GetOptions()
        {
            return await _context.Options.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Options>> GetOptions(int id)
        {
            var options = await _context.Options.FindAsync(id);

            if (options == null)
            {
                return NotFound();
            }

            return options;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutOptions(int id, Options options)
        {
            if (id != options.Id)
            {
                return BadRequest();
            }

            _context.Entry(options).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OptionsExists(id))
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
        public async Task<ActionResult<CreateOptionDto>> PostOptions(CreateOptionDto options)
        {
            var entity = new Options
            {
                TestId = options.TestId,
                OptionText = options.OptionText,
                IsCorrect = options.IsCorrect,
                CreatedAt = DateTime.Now
            };

            _context.Options.Add(entity);
            await _context.SaveChangesAsync();

            options.Id = entity.Id;

            return CreatedAtAction(nameof(GetOptions), new { id = entity.Id }, options);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOptions(int id)
        {
            var options = await _context.Options.FindAsync(id);
            if (options == null)
            {
                return NotFound();
            }

            _context.Options.Remove(options);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OptionsExists(int id)
        {
            return _context.Options.Any(e => e.Id == id);
        }
    }
}
