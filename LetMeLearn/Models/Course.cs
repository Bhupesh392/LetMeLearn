using System;
namespace LetMeLearn.Models
{
    public class Course
    {
        public CourseType CourseType { get; set; }
        public string ImageData { get; set; }
        public string CourseDescription { get; set; }
    }

    public enum CourseType
    {
        WebMaster,
        BusinessAndAccounting,
        ScienceAndTechnology,
        HealthAndPsychology,
        MobileDevelopment,
        WebDevelopment
    }
}

