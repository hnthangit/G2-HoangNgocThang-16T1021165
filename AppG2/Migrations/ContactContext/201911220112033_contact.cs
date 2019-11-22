namespace AppG2.Migrations.ContactContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.IdUser);
            
            AddColumn("dbo.Contacts", "IdUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "IdUser");
            DropTable("dbo.Users");
        }
    }
}
