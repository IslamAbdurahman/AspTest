using AspTest.Models;

public class TestSessionTests
{
    public long Id { get; set; }
    public long TestSessionId { get; set; }   // must match
    public TestSessions TestSession { get; set; }

    public long TestId { get; set; }
    public Tests Test { get; set; }

    public ICollection<TestSessionAnswers> TestSessionAnswers { get; set; } = new List<TestSessionAnswers>();
}
