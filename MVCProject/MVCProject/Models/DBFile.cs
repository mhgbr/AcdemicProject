using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models
{
    public class DBFile : IdentityDbContext
    {
        public DBFile()
        {

        }
        public DBFile(DbContextOptions<DBFile> options) : base(options)
        {

        }
        public DbSet<Instructor> instrcutors { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StdWithCr> StdWithCrs { get; set; }
        public DbSet<InsWithCr> InsWithCrs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.

                UseSqlServer("Data Source=.;Initial Catalog=team;Integrated Security=True");
        }

    }
}
