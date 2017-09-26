namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class interactionWithTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interactions", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Interactions", "Title");
        }
    }
}
