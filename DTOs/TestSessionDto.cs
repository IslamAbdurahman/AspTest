using AspTest.DTOs;

namespace AspTest.Dtos
{
    public class TestSessionDto
    {
        public long Id { get; set; }
        public long UserId { get; set; }

        public DateTime StartedAt { get; set; } = DateTime.Now;
        public DateTime? CompletedAt { get; set; }

        public int CorrectCount { get; set; } = 0;
        public int Minutes { get; set; } = 30;

        public string Status { get; set; } = "In Progress";

        public string? UserName { get; set; }

        // 🔹 Bu yerda testlar va ularning options’lari
        public List<TestDto> Tests { get; set; } = new();
    }
}
