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
            modelBuilder.Entity<Materias>().HasData(new Materias
            {
                MateriaId = 1,
                Codigo = "Mat-302",
                Nombre = "Matematicas"
            }
            );

            modelBuilder.Entity<Estudiantes>().HasData(new Estudiantes
            {
                EstudianteId = 1,
                Nombre = "Carlos",
                Apellido = "Lopez",
                FechaNacimiento = DateTime.Now,
                Direccion = "Villa tapia",
                Telefono = "809-887-3454",
                Celular = "809-433-2344",
                Correo = "Carlos@gmail.com"
            }
            );

            modelBuilder.Entity<Cursos>().HasData(new Cursos
            {
                CursoId = 1,
                Codigo = "Inf-200",
                Nombre = "Informatica",
              
            }
           );

            modelBuilder.Entity<Incripciones>().HasData(new Incripciones
            {
                IncripcionId = 1,
                EstudianteId = 1,
                CursoId = 1,
                Fecha = DateTime.Now
            }
           );

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

            modelBuilder.Entity<Areas>().HasData(new Areas
            {
                AreaId = 1,
                Descripcion = "Biologia"
            }
          );

            modelBuilder.Entity<Profesores>().HasData(new Profesores
            {
                ProfesorId = 1,
                Nombres = "Johan",
                Apellidos = "Lopez",
                Direccion = "Cenovi",
                Telefono = "908-234-1234",
                Celular = "890-123-3343",
                AreaId = 1,
                FechaIngreso = DateTime.Now,
                FechaNacimiento = DateTime.Now,
                Correo = "Johan@gmail.com"
            }
          );

            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombre = "Carlos",
                Apellido = "Solorin",
                NombreUsuario = "Admin",
                Clave = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                //1234
                FechaCreacion = DateTime.Now,
                RolId = 1
            }
            );
        }
    }
}
