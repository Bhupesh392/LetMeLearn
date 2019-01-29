using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using LetMeLearn.Helpers;
using LetMeLearn.Models;

namespace LetMeLearn.Controllers
{
    public class CourseController : Controller
    {
        List<Course> courses = new List<Course>();
        public ActionResult Index()
        {
            courses.Add(new Course()
            {
                ImageData = "",
                CourseType = EnumHelper.GetDescription(CourseType.BusinessAndAccounting),
                CourseDescription = "Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius molestias accusamus alias autem provident. Odit ab aliquam dolor eius."
            });

            courses.Add(new Course()
            {
                ImageData = "",
                CourseType = EnumHelper.GetDescription(CourseType.HealthAndPsychology),
                CourseDescription = "Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius molestias accusamus alias autem provident. Odit ab aliquam dolor eius."
            });

            courses.Add(new Course()
            {
                ImageData = "",
                CourseType = EnumHelper.GetDescription(CourseType.MobileDevelopment),
                CourseDescription = "Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius molestias accusamus alias autem provident. Odit ab aliquam dolor eius."
            });

            courses.Add(new Course()
            {
                ImageData = "",
                CourseType = EnumHelper.GetDescription(CourseType.ScienceAndTechnology),
                CourseDescription = "Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius molestias accusamus alias autem provident. Odit ab aliquam dolor eius."
            });

            courses.Add(new Course()
            {
                ImageData = "",
                CourseType = EnumHelper.GetDescription(CourseType.WebDevelopment),
                CourseDescription = "Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius molestias accusamus alias autem provident. Odit ab aliquam dolor eius."
            });

            courses.Add(new Course()
            {
                ImageData = "",
                CourseType = EnumHelper.GetDescription(CourseType.WebMaster),
                CourseDescription = "Dignissimos asperiores vitae velit veniam totam fuga molestias accusamus alias autem provident. Odit ab aliquam dolor eius molestias accusamus alias autem provident. Odit ab aliquam dolor eius."
            });

            ViewBag.Courses = courses;

            return View ();
        }

    }
}
