namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentApiRelacjaAutorKsiazka : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ksiazkas", "Autor_Id", "dbo.Autors");
            DropIndex("dbo.Ksiazkas", new[] { "Autor_Id" });
            RenameColumn(table: "dbo.Ksiazkas", name: "Autor_Id", newName: "AutorId");
            AlterColumn("dbo.Ksiazkas", "AutorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ksiazkas", "AutorId");
            AddForeignKey("dbo.Ksiazkas", "AutorId", "dbo.Autors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ksiazkas", "AutorId", "dbo.Autors");
            DropIndex("dbo.Ksiazkas", new[] { "AutorId" });
            AlterColumn("dbo.Ksiazkas", "AutorId", c => c.Int());
            RenameColumn(table: "dbo.Ksiazkas", name: "AutorId", newName: "Autor_Id");
            CreateIndex("dbo.Ksiazkas", "Autor_Id");
            AddForeignKey("dbo.Ksiazkas", "Autor_Id", "dbo.Autors", "Id");
        }
    }
}
