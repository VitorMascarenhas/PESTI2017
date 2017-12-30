namespace PlataformaRPHD.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stepWithImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Steps", "Imagem", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Steps", "Imagem");
        }
    }
}
