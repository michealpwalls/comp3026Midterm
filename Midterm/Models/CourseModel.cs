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
        [Display(Name="Course Code")]
        public string CourseCode { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        [Required]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }
        [Required]
        [Display(Name = "Course Cost")]
        [DataType(DataType.Currency)]
        public float CourseCost { get; set; }
    }

    public class CoursesDbContext : DbContext
    {
        public virtual DbSet<CourseModel> Courses { get; set; }
    }
}