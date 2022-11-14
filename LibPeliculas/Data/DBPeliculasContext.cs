using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LibPeliculas.Entidades
{
    public partial class DBPeliculasContext : DbContext
    {
        public DBPeliculasContext()
            : base("Model1")
        {
        }

        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Clasificacion> Clasificaciones{ get; set; }
        public virtual DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>()
                .HasMany(e => e.Peliculas)
                .WithRequired(e => e.Genero)
                .HasForeignKey(e => e.GeneroId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.Peliculas)
                .WithRequired(e => e.Clasificacion)
                .WillCascadeOnDelete(false);
        }
    }
}
