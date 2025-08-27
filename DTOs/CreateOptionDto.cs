using System.ComponentModel.DataAnnotations;

namespace AspTest.DTOs
{
    public class CreateOptionDto
    {
        public long Id { get; set; }
        [Required]
        public long TestId { get; set; }
        [Required]
        public string OptionText { get; set; }
        [Required]
        public bool IsCorrect { get; set; }

    }
}
