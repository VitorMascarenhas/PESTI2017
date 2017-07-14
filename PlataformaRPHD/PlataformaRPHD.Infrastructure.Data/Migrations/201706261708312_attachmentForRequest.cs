namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class attachmentForRequest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attachments", "Interaction_Id", "dbo.Interactions");
            DropIndex("dbo.Attachments", new[] { "Interaction_Id" });
            AddColumn("dbo.Attachments", "RequestId", c => c.Int(nullable: false));
            CreateIndex("dbo.Attachments", "RequestId");
            AddForeignKey("dbo.Attachments", "RequestId", "dbo.Requests", "Id", cascadeDelete: true);
            DropColumn("dbo.Attachments", "InterationId");
            DropColumn("dbo.Attachments", "Interaction_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Attachments", "Interaction_Id", c => c.Int());
            AddColumn("dbo.Attachments", "InterationId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Attachments", "RequestId", "dbo.Requests");
            DropIndex("dbo.Attachments", new[] { "RequestId" });
            DropColumn("dbo.Attachments", "RequestId");
            CreateIndex("dbo.Attachments", "Interaction_Id");
            AddForeignKey("dbo.Attachments", "Interaction_Id", "dbo.Interactions", "Id");
        }
    }
}
