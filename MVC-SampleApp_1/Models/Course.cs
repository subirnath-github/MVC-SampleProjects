using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_SampleApp_1.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int TotalCredits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}