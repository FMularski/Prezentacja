namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDrugieImieColumnToAutorTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autors", "DrugieImie", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Autors", "DrugieImie");
        }
    }
}
