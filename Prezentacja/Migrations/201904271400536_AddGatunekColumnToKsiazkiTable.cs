namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGatunekColumnToKsiazkiTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ksiazkas", "Gatunek_Id", c => c.Int());
            CreateIndex("dbo.Ksiazkas", "Gatunek_Id");
            AddForeignKey("dbo.Ksiazkas", "Gatunek_Id", "dbo.Gatuneks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ksiazkas", "Gatunek_Id", "dbo.Gatuneks");
            DropIndex("dbo.Ksiazkas", new[] { "Gatunek_Id" });
            DropColumn("dbo.Ksiazkas", "Gatunek_Id");
        }
    }
}
