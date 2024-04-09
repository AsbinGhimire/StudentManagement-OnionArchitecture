using Domain.StudentCRUD;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.StudentCRUD
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7OILLBJ\\SQLEXPRESS01;Database=CleanArchitectureStudentData;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }

        public DbSet<Student> Students { get; set; }   
    }
}