namespace AspTest.DTOs
{
    public class CreateTestSessionAnswerDto
    {
        public long Id { get; set; }

        public long TestSessionTestId { get; set; }
        public long SelectedOptionId { get; set; }
    }
}
