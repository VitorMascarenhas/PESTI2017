namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SatisfactionWithDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SatisfactionSurveys", "answer1", c => c.String());
            AddColumn("dbo.SatisfactionSurveys", "answer2", c => c.String());
            AddColumn("dbo.SatisfactionSurveys", "suggestion", c => c.String());
            AddColumn("dbo.SatisfactionSurveys", "clesed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SatisfactionSurveys", "clesed");
            DropColumn("dbo.SatisfactionSurveys", "suggestion");
            DropColumn("dbo.SatisfactionSurveys", "answer2");
            DropColumn("dbo.SatisfactionSurveys", "answer1");
        }
    }
}
