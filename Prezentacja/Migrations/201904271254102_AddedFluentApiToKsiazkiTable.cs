namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFluentApiToKsiazkiTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ksiazkas", "Tytul", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Ksiazkas", "Tytul", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Ksiazkas", new[] { "Tytul" });
            AlterColumn("dbo.Ksiazkas", "Tytul", c => c.String());
        }
    }
}
