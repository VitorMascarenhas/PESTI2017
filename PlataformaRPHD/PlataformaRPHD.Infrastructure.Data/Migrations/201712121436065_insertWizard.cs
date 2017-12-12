namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertWizard : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Notifications", "Service_Id", "dbo.Services");
            DropIndex("dbo.Notifications", new[] { "Service_Id" });
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Steps", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Wizards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Approved = c.Boolean(nullable: false),
                        Step_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Steps", t => t.Step_Id)
                .Index(t => t.Step_Id);
            
            DropTable("dbo.Notifications");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OpenSubject = c.String(),
                        CloseSubject = c.String(),
                        OpenBody = c.String(),
                        CloseBody = c.String(),
                        Service_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Wizards", "Step_Id", "dbo.Steps");
            DropForeignKey("dbo.Steps", "ParentId", "dbo.Steps");
            DropIndex("dbo.Wizards", new[] { "Step_Id" });
            DropIndex("dbo.Steps", new[] { "ParentId" });
            DropTable("dbo.Wizards");
            DropTable("dbo.Steps");
            CreateIndex("dbo.Notifications", "Service_Id");
            AddForeignKey("dbo.Notifications", "Service_Id", "dbo.Services", "Id");
        }
    }
}
