namespace AspTest.DTOs
{
    public class TestDto
    {
        public long Id { get; set; }
        public string QuestionText { get; set; }
        public bool IsActive { get; set; }
        public List<OptionDto> Options { get; set; }
    }
}
