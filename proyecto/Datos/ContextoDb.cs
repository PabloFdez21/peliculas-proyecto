using Microsoft.EntityFrameworkCore;
using proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Datos
{
    public class ContextoDb:DbContext
    {
        public ContextoDb(DbContextOptions<ContextoDb> options): base(options) //constructor
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //necesario cuando usemos las tablas de autentificacion para no tener que seleccionar automaticamente el id
            //mirar          
            modelBuilder.Entity<Actor_Pelicula>().HasKey(ap => new
            {
                ap.ActorId,
                ap.PeliculaId 
                //ap = Actor Pelicula
            });

            modelBuilder.Entity<Actor_Pelicula>().HasOne(p => p.Pelicula).WithMany(ap => ap.Actor_Pelciulas).HasForeignKey(p => p.PeliculaId);


            modelBuilder.Entity<Actor_Pelicula>().HasOne(p => p.Actor).WithMany(ap => ap.Actor_Peliculas).HasForeignKey(p => p.ActorId);
           
                base.OnModelCreating(modelBuilder);

            

        }

        //Definir nombre de tablas para cada modelo

        public DbSet<Actores> Actores { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Actor_Pelicula> Actores_Peliculas { get; set; }
        public DbSet<DondeVer> Dondevers { get; set; }
        public DbSet<Director> Directores { get; set; }

    }
}
