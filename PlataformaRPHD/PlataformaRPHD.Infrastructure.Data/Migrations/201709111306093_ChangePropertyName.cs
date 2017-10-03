namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePropertyName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SatisfactionSurveys", "closed", c => c.Boolean(nullable: false));
            DropColumn("dbo.SatisfactionSurveys", "clesed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SatisfactionSurveys", "clesed", c => c.Boolean(nullable: false));
            DropColumn("dbo.SatisfactionSurveys", "closed");
        }
    }
}
