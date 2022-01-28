using Microsoft.EntityFrameworkCore;

namespace MVCProject.Models
{
    public class DBFile :DbContext
    {

        public DbSet<Instructor> instrcutors { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<StdWithCr> StdWithCrs { get; set; }
        public DbSet<InsWithCr> InsWithCrs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Data Source=.;Initial Catalog=AcdemicPro;Integrated Security=True");
            
        }

    }
}
