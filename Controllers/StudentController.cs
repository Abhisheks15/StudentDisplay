using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppAzureExer01.Models;

namespace WebAppAzureExer01.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Display()
        {
            List<Student> objStu = new List<Student>
            {
                new Student{SId=1,SName="Abhishek",SDob=DateTime.Parse("12/12/2002"),SContact="9632581470"},
                new Student{SId=2,SName="Kavya",SDob=DateTime.Parse("12/02/2004"),SContact="9632581471"},
                new Student{SId=3,SName="Rohan",SDob=DateTime.Parse("10/04/2003"),SContact="9632581472"},
                new Student{SId=4,SName="Hemant",SDob=DateTime.Parse("11/06/2005"),SContact="9632581473"},
                new Student{SId=5,SName="Rajneesh",SDob=DateTime.Parse("01/01/2004"),SContact="9632581474"},
            };
            ViewBag.nos = objStu.Count;
            return View(objStu);
        }
    }
}
