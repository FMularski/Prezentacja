namespace Prezentacja.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Prezentacja.KsiegarniaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Prezentacja.KsiegarniaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Autorzy.AddOrUpdate(a => a.Id,
                new Autor { Imie = "Jan", DrugieImie = "Adam", Nazwisko = "Kowalski" },
                new Autor { Imie = "Grzegorz", Nazwisko = "Kot"},
                new Autor { Imie = "Maciej", DrugieImie = "Andrzej", Nazwisko = "Nowak"}
                );
        }
    }
}
