using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prezentacja
{
    class Ksiazka
    {
        public int Id { get; set; }
        public String Tytul { get; set; }
        public DateTime Publikacja { get; set; }

        public Autor Autor { get; set; }
        public Gatunek Gatunek { get; set; }

        public override string ToString()
        {
            return $"'{Tytul}' {Autor.Imie} {Autor.Nazwisko} \t{Gatunek.Nazwa} {Publikacja.ToShortDateString()} ";
        }
    }
}
