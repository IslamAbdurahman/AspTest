using AspTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace AspTest.Data
{
    public class AspTestDbContext : DbContext
    {
        public AspTestDbContext(DbContextOptions<AspTestDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 🔹 Default admin foydalanuvchi
            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    Id = 1,
                    Username = "admin",
                    PasswordHash = "21232f297a57a5a743894a0e4a801fc3", // MD5: "admin"
                    CreatedAt = new DateTime(2025, 01, 01)
                }
            );

            // 🔹 Relationships konfiguratsiya

            // TestSessionTests → TestSessions
            modelBuilder.Entity<TestSessionTests>()
                .HasOne(tst => tst.TestSession)
                .WithMany(ts => ts.TestSessionTests)
                .HasForeignKey(tst => tst.TestSessionId)
                .OnDelete(DeleteBehavior.NoAction);

            // TestSessionTests → Tests
            modelBuilder.Entity<TestSessionTests>()
                .HasOne(tst => tst.Test)
                .WithMany(t => t.TestSessionTests)
                .HasForeignKey(tst => tst.TestId)
                .OnDelete(DeleteBehavior.NoAction);

            // TestSessionAnswers → TestSessionTests
            modelBuilder.Entity<TestSessionAnswers>()
                .HasOne(a => a.TestSessionTest)
                .WithMany(tst => tst.TestSessionAnswers)
                .HasForeignKey(a => a.TestSessionTestId)
                .OnDelete(DeleteBehavior.NoAction);

            // TestSessionAnswers → Options
            modelBuilder.Entity<TestSessionAnswers>()
                .HasOne(a => a.Option)
                .WithMany()
                .HasForeignKey(a => a.SelectedOptionId)
                .OnDelete(DeleteBehavior.NoAction);

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "seed", "tests.json");
            var jsonData = File.ReadAllText(path);
            var tests = JsonSerializer.Deserialize<List<Tests>>(jsonData);

            if (tests != null)
            {
                // Tests
                var testsData = tests.Select(t => new Tests
                {
                    Id = t.Id,
                    QuestionText = t.QuestionText,
                    IsActive = t.IsActive,
                    CreatedAt = t.CreatedAt
                }).ToList();

                modelBuilder.Entity<Tests>().HasData(testsData);

                // Options
                var optionsData = tests.SelectMany(t => t.Options.Select(o => new Options
                {
                    Id = o.Id,
                    TestId = t.Id,
                    OptionText = o.OptionText,
                    IsCorrect = o.IsCorrect,
                    CreatedAt = o.CreatedAt
                })).ToList();

                modelBuilder.Entity<Options>().HasData(optionsData);
            }

        }

        // 🔹 DbSet lar
        public DbSet<Users> Users { get; set; }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<TestSessionTests> TestSessionTests { get; set; }
        public DbSet<TestSessionAnswers> TestSessionAnswers { get; set; }
        public DbSet<TestSessions> TestSessions { get; set; }

    }
}
