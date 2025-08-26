using AspTest.Models;

public class TestSessions
{
    public long Id { get; set; }  // 🔥 change to long
    public long UserId { get; set; }
    public Users User { get; set; }
    public long TestId { get; set; }
    public Tests Test { get; set; }

    public DateTime StartedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public int CorrectCount { get; set; } = 0;
    public int Minutes { get; set; } = 0;

    public ICollection<TestSessionTests> TestSessionTests { get; set; } = new List<TestSessionTests>();

    public string Status
    {
        get
        {
            if (CompletedAt.HasValue) return "Completed";
            else if ((DateTime.Now - StartedAt).TotalMinutes > Minutes && Minutes > 0) return "Timed Out";
            else return "In Progress";
        }
    }
}
