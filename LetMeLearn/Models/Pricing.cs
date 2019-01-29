using System;
namespace LetMeLearn.Models
{
    public class Pricing
    {
        public Category Category { get; set; }
        public int Price { get; set; }
        public string Access { get; set; }
        public string Limitations { get; set; }
        public int FreeLessons { get; set; }
        public string Supporter { get; set; }
        public string Downloads { get; set; }
        public string EBooks { get; set; }
        public string RegisteredUser { get; set; }
    }
}

public enum Category
{
    Trial,
    Silver,
    Gold
}
