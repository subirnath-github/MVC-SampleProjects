using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_SampleApp_1.Models
{
    public class Students
    {
        public int StudentsID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}