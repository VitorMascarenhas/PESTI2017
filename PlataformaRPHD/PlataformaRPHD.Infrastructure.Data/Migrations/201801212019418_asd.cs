namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resolutions", "ResolutionType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resolutions", "ResolutionType");
        }
    }
}
