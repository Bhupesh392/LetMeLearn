using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LetMeLearn.Models;

namespace LetMeLearn.Controllers
{
    public class TeacherController : Controller
    {
        List<Teachers> teachers = new List<Teachers>();
        public ActionResult Index()
        {

            teachers.Add(new Teachers() { 
            Name = "Bhupesh Sharma", 
            Domain="Xamarin Developement", 
            Description= "This is going to be some random text which can be used for description for defining the teacher which is basically an object of Teachers class."
            });

            teachers.Add(new Teachers() { 
            Name = "Mike Smith",
            Domain = "Health Teacher",
            Description = "This is going to be some random text which can be used for description for defining the teacher which is basically an object of Teachers class"
            });

            teachers.Add(new Teachers()
            {
                Name = "Worth Millors",
                Domain = "Accounts Teacher",
                Description = "This is going to be some random text which can be used for description for defining the teacher which is basically an object of Teachers class"
            });

            teachers.Add(new Teachers()
            {
                Name = "Hens Kovic",
                Domain = "Finance Teacher",
                Description = "This is going to be some random text which can be used for description for defining the teacher which is basically an object of Teachers class"
            });

            teachers.Add(new Teachers()
            {
                Name = "Den Whitining",
                Domain = "Maths Teacher",
                Description = "This is going to be some random text which can be used for description for defining the teacher which is basically an object of Teachers class"
            });

            teachers.Add(new Teachers()
            {
                Name = "Adam Shovic",
                Domain = "Python Teacher",
                Description = "This is going to be some random text which can be used for description for defining the teacher which is basically an object of Teachers class"
            });

            teachers.Add(new Teachers()
            {
                Name = "Matt Feather",
                Domain = "Artificial Teacher",
                Description = "This is going to be some random text which can be used for description for defining the teacher which is basically an object of Teachers class"
            });

            teachers.Add(new Teachers()
            {
                Name = "Remy Schovnic",
                Domain = "Android Teacher",
                Description = "This is going to be some random text which can be used for description for defining the teacher which is basically an object of Teachers class"
            });

            ViewBag.Teachers = teachers;

            return View ();
        }
    }
}
