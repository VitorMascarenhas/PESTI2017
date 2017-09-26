namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requestWithContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attachments", "Name", c => c.String());
            AddColumn("dbo.Requests", "contact", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requests", "contact");
            DropColumn("dbo.Attachments", "Name");
        }
    }
}
