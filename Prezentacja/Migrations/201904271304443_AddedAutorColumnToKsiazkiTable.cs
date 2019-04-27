namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAutorColumnToKsiazkiTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ksiazkas", "Autor_Id", c => c.Int());
            CreateIndex("dbo.Ksiazkas", "Autor_Id");
            AddForeignKey("dbo.Ksiazkas", "Autor_Id", "dbo.Autors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ksiazkas", "Autor_Id", "dbo.Autors");
            DropIndex("dbo.Ksiazkas", new[] { "Autor_Id" });
            DropColumn("dbo.Ksiazkas", "Autor_Id");
        }
    }
}
