using AspTest.Data;
using AspTest.DTOs;
using AspTest.Models;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestUploadController : ControllerBase
    {
        private readonly AspTestDbContext _context;

        public TestUploadController(AspTestDbContext context)
        {
            _context = context;
        }

        [HttpPost("UploadTests")]
        public async Task<IActionResult> UploadTests([FromForm] ExcelUploadDto dto)
        {
            if (dto.File == null || dto.File.Length == 0)
                return BadRequest("No file selected.");

            using var stream = dto.File.OpenReadStream();
            using var workbook = new XLWorkbook(stream);
            var worksheet = workbook.Worksheet(1); 
            var rowCount = worksheet.LastRowUsed().RowNumber();

            for (int row = 2; row <= rowCount; row++) 
            {
                var questionText = worksheet.Cell(row, 1).GetValue<string>(); 
                var isActive = worksheet.Cell(row, 2).GetValue<bool>();       

                var test = new Tests
                {
                    QuestionText = questionText,
                    IsActive = isActive,
                    CreatedAt = DateTime.UtcNow
                };

                _context.Tests.Add(test);
                await _context.SaveChangesAsync();

                for (int col = 3; col <= 6; col++)
                {
                    var optionText = worksheet.Cell(row, col).GetValue<string>();
                    if (string.IsNullOrEmpty(optionText)) continue;

                    bool isCorrect = worksheet.Cell(row, col + 4).GetValue<int>() == 1;

                    var option = new Options
                    {
                        TestId = test.Id,
                        OptionText = optionText,
                        IsCorrect = isCorrect,
                        CreatedAt = DateTime.UtcNow
                    };

                    _context.Options.Add(option);
                }

                await _context.SaveChangesAsync();
            }

            return Ok("Upload complete.");
        }
    }
}
