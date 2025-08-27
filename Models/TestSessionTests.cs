using AspTest.Models;
using System.Text.Json.Serialization;

public class TestSessionTests
{
    public long Id { get; set; }
    public long TestSessionId { get; set; }

    [JsonIgnore]
    public TestSessions TestSession { get; set; }

    public long TestId { get; set; }
    public Tests Test { get; set; }

    public ICollection<TestSessionAnswers> TestSessionAnswers { get; set; } = new List<TestSessionAnswers>();
}
