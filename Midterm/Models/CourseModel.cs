namespace Midterm.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CourseModel
    {
        public int ID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public float CourseCost { get; set; }
    }

    public class CoursesDbContext : DbContext
    {
        public virtual DbSet<CourseModel> Courses { get; set; }
    }
}