namespace AspTest.Models
{
    public class Tests
    {
        public long Id { get; set; }
        public string? QuestionText { get; set; } 
        public Boolean IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public List<Options> Options { get; set; }

        public List<TestSessionTests> TestSessionTests { get; set; }
    }
}
