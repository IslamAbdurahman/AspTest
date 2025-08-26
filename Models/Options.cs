using System.Text.Json.Serialization;

namespace AspTest.Models
{
    public class Options
    {
        public long Id { get; set; }
        public long TestId { get; set; }

        [JsonIgnore]
        public Tests Test { get; set; }

        public string? OptionText { get; set; }
        public bool IsCorrect { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
}
