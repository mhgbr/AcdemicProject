using System.ComponentModel.DataAnnotations;

namespace MVCProject.ViewModel
{
    public class StudentWithCrsDegreeVM
    {
        public int Id { get; set; }
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Display(Name = "Course Name")]
        public string CrsName { get; set; }
        public float Degree { get; set; }
    }
}
