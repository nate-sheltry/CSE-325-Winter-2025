using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SheltryUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        [Display(Name = "Enrollment ID")]
        public int EnrollmentID { get; set; }

        [Display(Name = "Course ID")]
        public int CourseID { get; set; }

        [Display(Name = "Student ID")]
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}