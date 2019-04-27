using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prezentacja
{
    class Autor
    {
        public int Id { get; set; }
        public String Imie { get; set; }
        public String DrugieImie { get; set; }
        public String Nazwisko { get; set; }

        public List<Ksiazka> Ksiazki { get; set; }
    }
}
