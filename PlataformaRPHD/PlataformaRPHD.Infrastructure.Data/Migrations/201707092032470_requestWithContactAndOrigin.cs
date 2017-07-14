namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requestWithContactAndOrigin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "origin", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requests", "origin");
        }
    }
}
