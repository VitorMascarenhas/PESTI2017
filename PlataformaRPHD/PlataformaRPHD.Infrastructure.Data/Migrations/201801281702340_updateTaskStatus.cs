namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTaskStatus : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ChangeTaskStatus", "TaskStatus_Id", "dbo.TaskStatus");
            DropForeignKey("dbo.Tasks", "status_Id", "dbo.TaskStatus");
            DropIndex("dbo.Tasks", new[] { "status_Id" });
            DropIndex("dbo.ChangeTaskStatus", new[] { "TaskStatus_Id" });
            AddColumn("dbo.Tasks", "Status", c => c.String());
            AddColumn("dbo.ChangeTaskStatus", "Description", c => c.String());
            AddColumn("dbo.ChangeTaskStatus", "Status", c => c.String());
            DropColumn("dbo.Tasks", "status_Id");
            DropColumn("dbo.ChangeTaskStatus", "TaskStatus_Id");
            DropTable("dbo.TaskStatus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TaskStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ChangeTaskStatus", "TaskStatus_Id", c => c.Int());
            AddColumn("dbo.Tasks", "status_Id", c => c.Int());
            DropColumn("dbo.ChangeTaskStatus", "Status");
            DropColumn("dbo.ChangeTaskStatus", "Description");
            DropColumn("dbo.Tasks", "Status");
            CreateIndex("dbo.ChangeTaskStatus", "TaskStatus_Id");
            CreateIndex("dbo.Tasks", "status_Id");
            AddForeignKey("dbo.Tasks", "status_Id", "dbo.TaskStatus", "Id");
            AddForeignKey("dbo.ChangeTaskStatus", "TaskStatus_Id", "dbo.TaskStatus", "Id");
        }
    }
}
