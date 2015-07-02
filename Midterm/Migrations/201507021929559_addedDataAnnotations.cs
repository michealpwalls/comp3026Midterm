namespace Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CourseModels", "CourseCode", c => c.String(nullable: false));
            AlterColumn("dbo.CourseModels", "CourseName", c => c.String(nullable: false));
            AlterColumn("dbo.CourseModels", "CourseDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CourseModels", "CourseDescription", c => c.String());
            AlterColumn("dbo.CourseModels", "CourseName", c => c.String());
            AlterColumn("dbo.CourseModels", "CourseCode", c => c.String());
        }
    }
}
