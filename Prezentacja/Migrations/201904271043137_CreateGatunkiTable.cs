namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGatunkiTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gatuneks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Gatuneks");
        }
    }
}
