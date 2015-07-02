namespace Midterm.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class CourseModel
    {
        public int ID { get; set; }
        [Required]
        public string CourseCode { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string CourseDescription { get; set; }
        [Required]
        public float CourseCost { get; set; }
    }

    public class CoursesDbContext : DbContext
    {
        public virtual DbSet<CourseModel> Courses { get; set; }
    }
}