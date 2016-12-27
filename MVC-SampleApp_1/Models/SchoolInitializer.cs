using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_SampleApp_1.Models
{
    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            List<Students> studentSeedList = new List<Students>
            {
                new Students { FirstName="Alex", LastName = "Parish", EnrollmentDate = DateTime.Parse("2014-12-12")},
                new Students { FirstName = "John", LastName = "Cena", EnrollmentDate = DateTime.Parse("2013-12-12")},
                new Students { FirstName = "Rayan", LastName = "Booth", EnrollmentDate = DateTime.Parse("2012-12-12") }
            };

            foreach (var item in studentSeedList)
            {
                context.Students.Add(item);
            }
            context.SaveChanges();

            List<Course> courseSeedList = new List<Course>
            {
                new Course {CourseName = ".NET", TotalCredits = 4 },
                new Course {CourseName = "Java", TotalCredits = 3 }
            };

            foreach(var item in courseSeedList)
            {
                context.Courses.Add(item);
            }
            context.SaveChanges();

            var enrollmentSeedList = new List<Enrollment>
            {
                new Enrollment {StudentsID = 1, CourseID = 1, Grade= 4  },
                new Enrollment {StudentsID = 2, CourseID = 2, Grade= 3  },
                new Enrollment {StudentsID = 3, CourseID = 1, Grade= 5  }
            };

            foreach (var item in enrollmentSeedList)
            {
                context.Enrollments.Add(item);
            }
            context.SaveChanges();
        }
    }
}