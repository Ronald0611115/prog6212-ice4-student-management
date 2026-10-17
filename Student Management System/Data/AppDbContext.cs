using Microsoft.EntityFrameworkCore;
using Student_Management_System.Models;
using Student_Management_System.Models;

namespace Student_Management_System.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { ID = 1, StudentNumber = "ST001", Name = "Lefa", Mark = 75 },
                new Student { ID = 2, StudentNumber = "ST002", Name = "Thabo", Mark = 62 },
                new Student { ID = 3, StudentNumber = "ST003", Name = "Naledi", Mark = 88 }
            );
        }
    }
}