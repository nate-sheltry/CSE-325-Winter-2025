using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SheltryUniversity.Models
{
    public class CourseAssignment
    {
        [Display(Name = "Instructor ID")]
        public int InstructorID { get; set; }

        [Display(Name = "Course ID")]
        public int CourseID { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}