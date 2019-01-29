using System;
using System.ComponentModel;

namespace LetMeLearn.Models
{
    public class Course
    {
        public string CourseType { get; set; }
        public string ImageData { get; set; }
        public string CourseDescription { get; set; }
    }

    public enum CourseType
    {
        [Description("Web Master")]
        WebMaster,
        [Description("Business & Accounting")]
        BusinessAndAccounting,
        [Description("Science & Teachnology")]
        ScienceAndTechnology,
        [Description("Health & Psychology")]
        HealthAndPsychology,
        [Description("Mobile Development")]
        MobileDevelopment,
        [Description("Web Development")]
        WebDevelopment
    }
}

