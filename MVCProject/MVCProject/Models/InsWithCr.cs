using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class InsWithCr
    {

        public int Id { get; set; }

        [ForeignKey("Instructor")]
        public int InsId { get; set; }
        public Instructor Instructor { get; set; }

        [ForeignKey("Course")]
        public int CrsId { get; set; }
        public Course Course { get; set; }

    }
}
