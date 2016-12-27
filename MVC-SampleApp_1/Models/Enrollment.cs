using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_SampleApp_1.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentsID { get; set; }
        public decimal? Grade { get; set; }
        public Students students { get; set; }
        public Course course { get; set; }
    }
}