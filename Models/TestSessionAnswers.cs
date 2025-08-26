using AspTest.Models;

public class TestSessionAnswers
{
    public long Id { get; set; }

    public long TestSessionTestId { get; set; }
    public TestSessionTests TestSessionTest { get; set; }

    public long SelectedOptionId { get; set; }
    public Options Option { get; set; }

    public DateTime AnsweredAt { get; set; }
}
