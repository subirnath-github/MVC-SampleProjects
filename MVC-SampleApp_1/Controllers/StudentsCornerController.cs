using MVC_SampleApp_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_SampleApp_1.Controllers
{
    public class StudentsCornerController : Controller
    {
        public string Index()
        {
            //return View();
            return "From StudentsCornerController - Index Action method";
        }

        // GET: StudentsCorner
        public ActionResult StudentDetails()
        {
            Students stud1 = new Students { FirstName="Alex", LastName = "Parish"};
            Students stud2 = new Students { FirstName = "John", LastName = "Cena" };
            Students stud3 = new Students { FirstName = "Rayan", LastName = "Booth" };

            List<Students> studentsList = new List<Students>();
            studentsList.Add(stud1);
            studentsList.Add(stud2);
            studentsList.Add(stud3);

            return View(studentsList);
        }
    }
}