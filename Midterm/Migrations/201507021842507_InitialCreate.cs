namespace Midterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseCode = c.String(),
                        CourseName = c.String(),
                        CourseDescription = c.String(),
                        CourseCost = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CourseModels");
        }
    }
}
