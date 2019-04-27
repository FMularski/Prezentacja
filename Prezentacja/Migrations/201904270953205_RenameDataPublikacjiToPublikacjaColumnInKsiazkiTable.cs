namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDataPublikacjiToPublikacjaColumnInKsiazkiTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Ksiazkas", "DataPublikacji", "Publikacja");
        }

        public override void Down()
        {
            RenameColumn("dbo.Ksiazkas", "Publikacja", "DataPublikacji");
        }
    }
}
