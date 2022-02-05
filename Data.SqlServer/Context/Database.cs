using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebMotors.Domain.Entities;

namespace WebMotors.Data.SqlServer.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="options">Configuration options</param>
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public virtual DbSet<Anuncio> Anuncio { get; set; }


        /// <summary>
        /// Creates and configures the data model.
        /// </summary>
        /// <param name="mb">The current model builder</param>
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Domain.Entities.Anuncio>().ToTable("tb_AnuncioWebmotors");
            //mb.Entity<Blog.Data.Alias>().Property(a => a.AliasUrl).IsRequired().HasMaxLength(256);
            //mb.Entity<Blog.Data.Alias>().Property(a => a.RedirectUrl).IsRequired().HasMaxLength(256);
            //mb.Entity<Blog.Data.Alias>().HasIndex(a => new { a.SiteId, a.AliasUrl }).IsUnique();
        }

        public override int SaveChanges()
        {
            // Definindo a propriedade de DataCadastro com a hora atual e forçando desabilitar a modificação no update
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataAlteracao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataAlteracao").IsModified = false;

                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
         
    }
}
