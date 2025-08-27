using System.ComponentModel.DataAnnotations;

namespace AspTest.DTOs
{
    public class CreateTestSessionDto
    {
        public long Id { get; set; }
        [Required]
        public long UserId { get; set; }
            
    }
}
