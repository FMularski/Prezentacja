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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ksiazka>()
                .HasKey(k => k.Id);

            modelBuilder.Entity<Ksiazka>()
                .Property(k => k.Tytul)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Ksiazka>()
                .HasIndex(k => k.Tytul)
                .IsUnique();

            modelBuilder.Entity<Ksiazka>()
                .Property(k => k.Publikacja)
                .IsRequired();

            modelBuilder.Entity<Autor>()
                 .HasMany(a => a.Ksiazki)
                 .WithRequired(k => k.Autor)
                 .HasForeignKey(k => k.AutorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
