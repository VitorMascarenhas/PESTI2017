namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requestwithss : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SatisfactionSurveys", "RequestId", "dbo.Requests");
            DropIndex("dbo.SatisfactionSurveys", new[] { "RequestId" });
            AddColumn("dbo.Requests", "SatisfactionSurvey_Id", c => c.Int());
            CreateIndex("dbo.Requests", "SatisfactionSurvey_Id");
            AddForeignKey("dbo.Requests", "SatisfactionSurvey_Id", "dbo.SatisfactionSurveys", "Id");
            DropColumn("dbo.SatisfactionSurveys", "RequestId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SatisfactionSurveys", "RequestId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Requests", "SatisfactionSurvey_Id", "dbo.SatisfactionSurveys");
            DropIndex("dbo.Requests", new[] { "SatisfactionSurvey_Id" });
            DropColumn("dbo.Requests", "SatisfactionSurvey_Id");
            CreateIndex("dbo.SatisfactionSurveys", "RequestId");
            AddForeignKey("dbo.SatisfactionSurveys", "RequestId", "dbo.Requests", "Id", cascadeDelete: true);
        }
    }
}
