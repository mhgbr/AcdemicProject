using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class StdWithCr
    {
        public int Id { get; set; }

        public int Degree { get; set; }

        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Student")]
        public int StId { get; set; }
        public Student Student { get; set; }

    }
}
