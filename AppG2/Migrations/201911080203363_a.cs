namespace AppG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HistoryLearnings",
                c => new
                    {
                        IDHistoryLearning = c.String(nullable: false, maxLength: 128),
                        YearFrom = c.Int(nullable: false),
                        YearEnd = c.Int(nullable: false),
                        Address = c.String(),
                        IDStudent = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IDHistoryLearning)
                .ForeignKey("dbo.Students", t => t.IDStudent)
                .Index(t => t.IDStudent);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        IDStudent = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        POB = c.String(),
                    })
                .PrimaryKey(t => t.IDStudent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistoryLearnings", "IDStudent", "dbo.Students");
            DropIndex("dbo.HistoryLearnings", new[] { "IDStudent" });
            DropTable("dbo.Students");
            DropTable("dbo.HistoryLearnings");
        }
    }
}
