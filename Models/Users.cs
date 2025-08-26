namespace AspTest.Models
{
    public class Users
    {
        public long Id { get; set; }
        public string? Username { get; set; } 
        public string? PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
