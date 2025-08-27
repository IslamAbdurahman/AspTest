using System.ComponentModel.DataAnnotations;

namespace AspTest.DTOs
{
    public class CreateTestDto
    {
        public long Id { get; set; }
        [Required]
        public string QuestionText { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
