using AspTest.Models;
using Microsoft.EntityFrameworkCore;

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
