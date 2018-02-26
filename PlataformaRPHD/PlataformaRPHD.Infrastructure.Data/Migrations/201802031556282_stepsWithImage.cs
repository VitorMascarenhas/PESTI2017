namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stepsWithImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Steps", "ImageContent", c => c.Binary());
            AddColumn("dbo.Steps", "ImageType", c => c.String());
            AddColumn("dbo.Wizards", "CreateBy_Id", c => c.Int());
            CreateIndex("dbo.Wizards", "CreateBy_Id");
            AddForeignKey("dbo.Wizards", "CreateBy_Id", "dbo.Users", "Id");
            DropColumn("dbo.Steps", "Imagem");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Steps", "Imagem", c => c.Binary());
            DropForeignKey("dbo.Wizards", "CreateBy_Id", "dbo.Users");
            DropIndex("dbo.Wizards", new[] { "CreateBy_Id" });
            DropColumn("dbo.Wizards", "CreateBy_Id");
            DropColumn("dbo.Steps", "ImageType");
            DropColumn("dbo.Steps", "ImageContent");
        }
    }
}
