namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApiRelationAutorKsiazki : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ksiazkas", "Autor_Id", "dbo.Autors");
            DropIndex("dbo.Ksiazkas", new[] { "Autor_Id" });
            AlterColumn("dbo.Ksiazkas", "Autor_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Ksiazkas", "Autor_Id");
            AddForeignKey("dbo.Ksiazkas", "Autor_Id", "dbo.Autors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ksiazkas", "Autor_Id", "dbo.Autors");
            DropIndex("dbo.Ksiazkas", new[] { "Autor_Id" });
            AlterColumn("dbo.Ksiazkas", "Autor_Id", c => c.Int());
            CreateIndex("dbo.Ksiazkas", "Autor_Id");
            AddForeignKey("dbo.Ksiazkas", "Autor_Id", "dbo.Autors", "Id");
        }
    }
}
