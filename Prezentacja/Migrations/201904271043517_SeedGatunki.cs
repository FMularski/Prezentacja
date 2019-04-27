namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGatunki : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Gatuneks (Nazwa) VALUES ('Fantastyka')");
            Sql("INSERT INTO dbo.Gatuneks (Nazwa) VALUES ('Kryminal')");
            Sql("INSERT INTO dbo.Gatuneks (Nazwa) VALUES ('Horror')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM dbo.Gatuneks");
        }
    }
}
