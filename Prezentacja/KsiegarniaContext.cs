using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prezentacja
{
    class KsiegarniaContext: DbContext
    {
        public KsiegarniaContext() : base("name=Ksiegarnia") { ; }

        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Autor> Autorzy { get; set; }
        public DbSet<Gatunek> Gatunki { get; set; }
    }
}
