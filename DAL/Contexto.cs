using IncripcionesWPF.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncripcionesWPF.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Incripciones> Incripciones { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Materias> Materias { get; set; }
        public DbSet<Areas> Areas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\incripciones.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            
            modelBuilder.Entity<Roles>().HasData(new Roles
            {
              RolId = 1,
              Descripcion = "Admin"
            }
            );

            modelBuilder.Entity<Roles>().HasData(new Roles
            {
                RolId = 2,
                Descripcion = "Secretaria"
            }
           );


            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuariosId = 1,
                Nombre = "Carlos",
                Apellido = "Solorin",
                NombreUsuario = "Admin",
                Clave = "1234",
                FechaCreacion = DateTime.Now,
                RolId = 1
            }
            );

          
        }
    }
}
