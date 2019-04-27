using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Prezentacja
{
    class Program
    {
        static void Main(string[] args)
        {
            KsiegarniaContext Context = new KsiegarniaContext();

            /* Wyswietlenie ksiazek
            
            IEnumerable<Ksiazka> ksiazki = Context.Ksiazki
                .Include(k => k.Autor)
                .Include(k => k.Gatunek);

            foreach (Ksiazka ksiazka in ksiazki)
                Console.WriteLine(ksiazka);
            */

            /* Dodanie ksiazki
            
            Ksiazka ksiazka = new Ksiazka
            {
                Tytul = "Ksiazka 3",
                Publikacja = new DateTime(2019, 04, 27),
                Autor = Context.Autorzy.Single(a => a.Id == 1),
                Gatunek = Context.Gatunki.Single(g => g.Nazwa == "Fantastyka")
            };

            Context.Ksiazki.Add(ksiazka);
            Context.SaveChanges();
            */

            /* Modyfikacja ksiazki
             
            Ksiazka ksiazkaWBazie = Context.Ksiazki.Single(k => k.Id == 2);

            ksiazkaWBazie.Tytul = "Nowy tytul ksiazki 1";
            ksiazkaWBazie.Publikacja = DateTime.Now;

            Context.SaveChanges();

            */

            /* Usuniecie ksiazki
            
            Ksiazka ksiazkaWBazie = Context.Ksiazki.First();
            Context.Ksiazki.Remove(ksiazkaWBazie);

            Context.SaveChanges();

            */
        }
    }
}
