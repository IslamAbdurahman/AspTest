namespace AspTest.Models
{
    public class Options
    {
        public long Id { get; set; }
        public long TestId { get; set; }
        public Tests Test { get; set; }
        public string? OptionText { get; set; } 
        public Boolean IsCorrect { get; set; } = false;
        public DateTime CreatedAt { get; set; }
    }
}
