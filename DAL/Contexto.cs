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
        public DbSet<CursosDetalle> CursosDetalle { get; set; }
        public DbSet<ProfesoresDetalle> ProfesoresDetalle { get; set; }
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

            modelBuilder.Entity<Materias>().HasData(new Materias
            {
                MateriaId = 2,
                Codigo = "Len-102",
                Nombre = "Lengua Española"
            }
            );

            modelBuilder.Entity<Materias>().HasData(new Materias
            {
                MateriaId = 3,
                Codigo = "Prog-50",
                Nombre = "Programacion"
            }
           );

            modelBuilder.Entity<Materias>().HasData(new Materias
            {
                MateriaId = 4,
                Codigo = "Bio-300",
                Nombre = "Biologia"
            }
           );

            modelBuilder.Entity<Materias>().HasData(new Materias
            {
                MateriaId = 5,
                Codigo = "Qui-200",
                Nombre = "Quimica"
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

            modelBuilder.Entity<Estudiantes>().HasData(new Estudiantes
            {
                EstudianteId = 2,
                Nombre = "Pedro",
                Apellido = "Solorin",
                FechaNacimiento = DateTime.Now,
                Direccion = "Cenovi",
                Telefono = "809-543-2344",
                Celular = "809-123-4563",
                Correo = "Pedro@gmail.com"
            }
           );

            modelBuilder.Entity<Estudiantes>().HasData(new Estudiantes
            {
                EstudianteId = 3,
                Nombre = "Luis",
                Apellido = "Gonzales",
                FechaNacimiento = DateTime.Now,
                Direccion = "Porquero",
                Telefono = "809-654-2344",
                Celular = "809-233-2343",
                Correo = "Luis@gmail.com"
            }
          );

            modelBuilder.Entity<Estudiantes>().HasData(new Estudiantes
            {
                EstudianteId = 4,
                Nombre = "Johan",
                Apellido = "Rodriguez",
                FechaNacimiento = DateTime.Now,
                Direccion = "Salcedo",
                Telefono = "809-543-2343",
                Celular = "809-123-5432",
                Correo = "Johan03@gmail.com"
            }
          );

            modelBuilder.Entity<Estudiantes>().HasData(new Estudiantes
            {
                EstudianteId = 5,
                Nombre = "Joel",
                Apellido = "Polanco",
                FechaNacimiento = DateTime.Now,
                Direccion = "Tenares",
                Telefono = "809-098-4322",
                Celular = "809-654-2343",
                Correo = "Joel@gmail.com"
            }
          );

            modelBuilder.Entity<Cursos>().HasData(new Cursos
            {
                CursoId = 1,
                Codigo = "Inf-200",
                Nombre = "Informatica",
              
            }
           );

            modelBuilder.Entity<Cursos>().HasData(new Cursos
            {
                CursoId = 2,
                Codigo = "Ref-500",
                Nombre = "Refrigeracion",

            }
           );

            modelBuilder.Entity<Cursos>().HasData(new Cursos
            {
                CursoId = 3,
                Codigo = "Elec-400",
                Nombre = "Eletricidad",

            }
           );

            modelBuilder.Entity<Cursos>().HasData(new Cursos
            {
                CursoId = 4,
                Codigo = "Meca-500",
                Nombre = "Mecanica"
            }
           );

            modelBuilder.Entity<Cursos>().HasData(new Cursos
            {
                CursoId = 5,
                Codigo = "Cont-420",
                Nombre = "Contabilidad",

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

            modelBuilder.Entity<Incripciones>().HasData(new Incripciones
            {
                IncripcionId = 2,
                EstudianteId = 2,
                CursoId = 2,
                Fecha = DateTime.Now
            }
           );

            modelBuilder.Entity<Incripciones>().HasData(new Incripciones
            {
                IncripcionId = 3,
                EstudianteId = 3,
                CursoId = 3,
                Fecha = DateTime.Now
            }
           );

            modelBuilder.Entity<Incripciones>().HasData(new Incripciones
            {
                IncripcionId = 4,
                EstudianteId = 4,
                CursoId = 4,
                Fecha = DateTime.Now
            }
           );

            modelBuilder.Entity<Incripciones>().HasData(new Incripciones
            {
                IncripcionId = 5,
                EstudianteId = 5,
                CursoId = 5,
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

            modelBuilder.Entity<Roles>().HasData(new Roles
            {
                RolId = 3,
                Descripcion = "Director"
            }
           );

            modelBuilder.Entity<Roles>().HasData(new Roles
            {
                RolId = 4,
                Descripcion = "Tecnico"
            }
           );

            modelBuilder.Entity<Roles>().HasData(new Roles
            {
                RolId = 5,
                Descripcion = "Supervisor"
            }
           );

            modelBuilder.Entity<Areas>().HasData(new Areas
            {
                AreaId = 1,
                Descripcion = "Biologia"
            }
          );

            modelBuilder.Entity<Areas>().HasData(new Areas
            {
                AreaId = 2,
                Descripcion = "Matematicas"
            }
          );

            modelBuilder.Entity<Areas>().HasData(new Areas
            {
                AreaId = 3,
                Descripcion = "Programacion"
            }
         );

            modelBuilder.Entity<Areas>().HasData(new Areas
            {
                AreaId = 4,
                Descripcion = "Lengua Española"
            }
         );

            modelBuilder.Entity<Areas>().HasData(new Areas
            {
                AreaId = 5,
                Descripcion = "Quimica"
            }
         );

            modelBuilder.Entity<Profesores>().HasData(new Profesores
            {
                ProfesorId = 1,
                Nombres = "Johan",
                Apellidos = "Lopez",
                Direccion = "Cenovi",
                Telefono = "849-234-1234",
                Celular = "809-123-3343",
                AreaId = 1,
                FechaIngreso = DateTime.Now,
                FechaNacimiento = DateTime.Now,
                Correo = "Johan@gmail.com"
            }
          );

            modelBuilder.Entity<Profesores>().HasData(new Profesores
            {
                ProfesorId = 2,
                Nombres = "Juan",
                Apellidos = "Villar",
                Direccion = "Cenovi",
                Telefono = "829-098-5243",
                Celular = "829-123-5432",
                AreaId = 2,
                FechaIngreso = DateTime.Now,
                FechaNacimiento = DateTime.Now,
                Correo = "Juan@gmail.com"
            }
          );

            modelBuilder.Entity<Profesores>().HasData(new Profesores
            {
                ProfesorId = 3,
                Nombres = "Jorgelis",
                Apellidos = "Villar",
                Direccion = "Tenares",
                Telefono = "829-543-4421",
                Celular = "829-126-0156",
                AreaId = 3,
                FechaIngreso = DateTime.Now,
                FechaNacimiento = DateTime.Now,
                Correo = "Jorgelis@gmail.com"
            }
          );

            modelBuilder.Entity<Profesores>().HasData(new Profesores
            {
                ProfesorId = 4,
                Nombres = "Mariam",
                Apellidos = "Polanco",
                Direccion = "Salcedo",
                Telefono = "829-123-0134",
                Celular = "829-454-8567",
                AreaId = 4,
                FechaIngreso = DateTime.Now,
                FechaNacimiento = DateTime.Now,
                Correo = "Mariam@gmail.com"
            }
          );

            modelBuilder.Entity<Profesores>().HasData(new Profesores
            {
                ProfesorId = 5,
                Nombres = "Maira",
                Apellidos = "Estrella",
                Direccion = "Villa Tapia",
                Telefono = "829-345-1309",
                Celular = "829-0345-6422",
                AreaId = 5,
                FechaIngreso = DateTime.Now,
                FechaNacimiento = DateTime.Now,
                Correo = "Maira@gmail.com"
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

            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 2,
                Nombre = "Pedro",
                Apellido = "Lopez",
                NombreUsuario = "PedroL",
                Clave = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                //1234
                FechaCreacion = DateTime.Now,
                RolId = 2
            }
            );

            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 3,
                Nombre = "Miriam",
                Apellido = "Santana",
                NombreUsuario = "MiriamS",
                Clave = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                FechaCreacion = DateTime.Now,
                RolId = 3
            }
            );

            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 4,
                Nombre = "Abelardo",
                Apellido = "Soto",
                NombreUsuario = "AbelardoS",
                Clave = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                FechaCreacion = DateTime.Now,
                RolId = 4
            }
            );

            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 5,
                Nombre = "Randis",
                Apellido = "Cruz",
                NombreUsuario = "RandisC",
                Clave = "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4",
                FechaCreacion = DateTime.Now,
                RolId = 5
            }
           );

            modelBuilder.Entity<ProfesoresDetalle>().HasData(new ProfesoresDetalle
            {
                ProfesorDetalleId = 1,
                ProfesorId = 1,
                MateriaId = 1
            }
           );

            modelBuilder.Entity<ProfesoresDetalle>().HasData(new ProfesoresDetalle
            {
                ProfesorDetalleId = 2,
                ProfesorId = 1,
                MateriaId = 2
            }
          );

            modelBuilder.Entity<ProfesoresDetalle>().HasData(new ProfesoresDetalle
            {
                ProfesorDetalleId = 3,
                ProfesorId = 1,
                MateriaId = 3
            }
          );

            modelBuilder.Entity<ProfesoresDetalle>().HasData(new ProfesoresDetalle
            {
                ProfesorDetalleId = 4,
                ProfesorId = 1,
                MateriaId = 4
            }
          );

            modelBuilder.Entity<ProfesoresDetalle>().HasData(new ProfesoresDetalle
            {
                ProfesorDetalleId = 5,
                ProfesorId = 1,
                MateriaId = 5
            }
          );

            modelBuilder.Entity<CursosDetalle>().HasData(new CursosDetalle
            {
                CursoDetalleId = 1,
                CursoId = 1,
                MateriaId = 1
            }
          );

            modelBuilder.Entity<CursosDetalle>().HasData(new CursosDetalle
            {
                CursoDetalleId = 2,
                CursoId = 1,
                MateriaId = 2
            }
          );

            modelBuilder.Entity<CursosDetalle>().HasData(new CursosDetalle
            {
                CursoDetalleId = 3,
                CursoId = 1,
                MateriaId = 3
            }
          );

            modelBuilder.Entity<CursosDetalle>().HasData(new CursosDetalle
            {
                CursoDetalleId = 4,
                CursoId = 1,
                MateriaId = 4
            }
          );

            modelBuilder.Entity<CursosDetalle>().HasData(new CursosDetalle
            {
                CursoDetalleId = 5,
                CursoId = 1,
                MateriaId = 5
            }
          );
        }
    }
}
