namespace CodeFiratApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            AddColumn("dbo.tblBatch", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.tblBatch", "CourseId");
            AddForeignKey("dbo.tblBatch", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
            DropColumn("dbo.tblBatch", "Course");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblBatch", "Course", c => c.String());
            DropForeignKey("dbo.tblBatch", "CourseId", "dbo.Courses");
            DropIndex("dbo.tblBatch", new[] { "CourseId" });
            DropColumn("dbo.tblBatch", "CourseId");
            DropTable("dbo.Courses");
        }
    }
}
