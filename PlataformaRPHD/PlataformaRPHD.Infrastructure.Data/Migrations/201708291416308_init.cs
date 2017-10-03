namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attachments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Request_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requests", t => t.Request_Id)
                .Index(t => t.Request_Id);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeOfRegistration = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 2500),
                        SourceComputer = c.String(maxLength: 50),
                        Contact = c.String(maxLength: 100),
                        Category_Id = c.Int(),
                        Impact_Id = c.Int(),
                        User_Id = c.Int(),
                        Origin_Id = c.Int(),
                        Owner_Id = c.Int(),
                        WhoRegistered_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Impacts", t => t.Impact_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Origins", t => t.Origin_Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id)
                .ForeignKey("dbo.Users", t => t.WhoRegistered_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Impact_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Origin_Id)
                .Index(t => t.Owner_Id)
                .Index(t => t.WhoRegistered_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(),
                        Name = c.String(),
                        Description = c.String(),
                        HasWizard = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.Impacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Interactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Request_Id = c.Int(),
                        service_Id = c.Int(),
                        Task_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requests", t => t.Request_Id)
                .ForeignKey("dbo.Services", t => t.service_Id)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .Index(t => t.Request_Id)
                .Index(t => t.service_Id)
                .Index(t => t.Task_Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        text = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        InteractionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Interactions", t => t.InteractionId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.InteractionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_FirstName = c.String(),
                        Name_LastName = c.String(),
                        mechanographicNumber = c.String(),
                        mail = c.String(),
                        phoneNumber = c.String(),
                        UserStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        close = c.Boolean(nullable: false),
                        Owner_Id = c.Int(),
                        Resolution_Id = c.Int(),
                        status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id)
                .ForeignKey("dbo.Resolutions", t => t.Resolution_Id)
                .ForeignKey("dbo.TaskStatus", t => t.status_Id)
                .Index(t => t.Owner_Id)
                .Index(t => t.Resolution_Id)
                .Index(t => t.status_Id);
            
            CreateTable(
                "dbo.ChangeTaskStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        changed = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        Task_Id = c.Int(),
                        TaskStatus_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Tasks", t => t.Task_Id)
                .ForeignKey("dbo.TaskStatus", t => t.TaskStatus_Id)
                .Index(t => t.UserId)
                .Index(t => t.Task_Id)
                .Index(t => t.TaskStatus_Id);
            
            CreateTable(
                "dbo.TaskStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Resolutions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        resolutionText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transfers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        description = c.String(),
                        tranfered = c.DateTime(nullable: false),
                        TaskId = c.Int(nullable: false),
                        FromUser_Id = c.Int(),
                        OfUser_Id = c.Int(),
                        WhoTransferred_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.FromUser_Id)
                .ForeignKey("dbo.Users", t => t.OfUser_Id)
                .ForeignKey("dbo.Tasks", t => t.TaskId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.WhoTransferred_Id)
                .Index(t => t.TaskId)
                .Index(t => t.FromUser_Id)
                .Index(t => t.OfUser_Id)
                .Index(t => t.WhoTransferred_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Origins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.Service_Id)
                .Index(t => t.Service_Id);
            
            CreateTable(
                "dbo.SatisfactionSurveys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requests", t => t.RequestId, cascadeDelete: true)
                .Index(t => t.RequestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SatisfactionSurveys", "RequestId", "dbo.Requests");
            DropForeignKey("dbo.Notifications", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.Requests", "WhoRegistered_Id", "dbo.Users");
            DropForeignKey("dbo.Requests", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.Requests", "Origin_Id", "dbo.Origins");
            DropForeignKey("dbo.Interactions", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.Interactions", "service_Id", "dbo.Services");
            DropForeignKey("dbo.Interactions", "Request_Id", "dbo.Requests");
            DropForeignKey("dbo.Messages", "InteractionId", "dbo.Interactions");
            DropForeignKey("dbo.Messages", "UserId", "dbo.Users");
            DropForeignKey("dbo.Transfers", "WhoTransferred_Id", "dbo.Users");
            DropForeignKey("dbo.Transfers", "TaskId", "dbo.Tasks");
            DropForeignKey("dbo.Transfers", "OfUser_Id", "dbo.Users");
            DropForeignKey("dbo.Transfers", "FromUser_Id", "dbo.Users");
            DropForeignKey("dbo.Tasks", "status_Id", "dbo.TaskStatus");
            DropForeignKey("dbo.Tasks", "Resolution_Id", "dbo.Resolutions");
            DropForeignKey("dbo.Tasks", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.ChangeTaskStatus", "TaskStatus_Id", "dbo.TaskStatus");
            DropForeignKey("dbo.ChangeTaskStatus", "Task_Id", "dbo.Tasks");
            DropForeignKey("dbo.ChangeTaskStatus", "UserId", "dbo.Users");
            DropForeignKey("dbo.Requests", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Requests", "Impact_Id", "dbo.Impacts");
            DropForeignKey("dbo.Requests", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Categories", "ParentId", "dbo.Categories");
            DropForeignKey("dbo.Attachments", "Request_Id", "dbo.Requests");
            DropIndex("dbo.SatisfactionSurveys", new[] { "RequestId" });
            DropIndex("dbo.Notifications", new[] { "Service_Id" });
            DropIndex("dbo.Transfers", new[] { "WhoTransferred_Id" });
            DropIndex("dbo.Transfers", new[] { "OfUser_Id" });
            DropIndex("dbo.Transfers", new[] { "FromUser_Id" });
            DropIndex("dbo.Transfers", new[] { "TaskId" });
            DropIndex("dbo.ChangeTaskStatus", new[] { "TaskStatus_Id" });
            DropIndex("dbo.ChangeTaskStatus", new[] { "Task_Id" });
            DropIndex("dbo.ChangeTaskStatus", new[] { "UserId" });
            DropIndex("dbo.Tasks", new[] { "status_Id" });
            DropIndex("dbo.Tasks", new[] { "Resolution_Id" });
            DropIndex("dbo.Tasks", new[] { "Owner_Id" });
            DropIndex("dbo.Messages", new[] { "InteractionId" });
            DropIndex("dbo.Messages", new[] { "UserId" });
            DropIndex("dbo.Interactions", new[] { "Task_Id" });
            DropIndex("dbo.Interactions", new[] { "service_Id" });
            DropIndex("dbo.Interactions", new[] { "Request_Id" });
            DropIndex("dbo.Categories", new[] { "ParentId" });
            DropIndex("dbo.Requests", new[] { "WhoRegistered_Id" });
            DropIndex("dbo.Requests", new[] { "Owner_Id" });
            DropIndex("dbo.Requests", new[] { "Origin_Id" });
            DropIndex("dbo.Requests", new[] { "User_Id" });
            DropIndex("dbo.Requests", new[] { "Impact_Id" });
            DropIndex("dbo.Requests", new[] { "Category_Id" });
            DropIndex("dbo.Attachments", new[] { "Request_Id" });
            DropTable("dbo.SatisfactionSurveys");
            DropTable("dbo.Notifications");
            DropTable("dbo.Origins");
            DropTable("dbo.Services");
            DropTable("dbo.Transfers");
            DropTable("dbo.Resolutions");
            DropTable("dbo.TaskStatus");
            DropTable("dbo.ChangeTaskStatus");
            DropTable("dbo.Tasks");
            DropTable("dbo.Users");
            DropTable("dbo.Messages");
            DropTable("dbo.Interactions");
            DropTable("dbo.Impacts");
            DropTable("dbo.Categories");
            DropTable("dbo.Requests");
            DropTable("dbo.Attachments");
        }
    }
}
