using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncripcionesWPF.Migrations
{
    public partial class PoniendoDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "Descripcion" },
                values: new object[] { 2, "Matematicas" });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "Descripcion" },
                values: new object[] { 3, "Programacion" });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "Descripcion" },
                values: new object[] { 4, "Lengua Española" });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "Descripcion" },
                values: new object[] { 5, "Quimica" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Codigo", "Nombre" },
                values: new object[] { 2, "Ref-500", "Refrigeracion" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Codigo", "Nombre" },
                values: new object[] { 3, "Con-400", "Contabilidad" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Codigo", "Nombre" },
                values: new object[] { 4, "Meca-500", "Mecanica" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Codigo", "Nombre" },
                values: new object[] { 5, "Cont-420", "Contabilidad" });

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Celular", "Correo", "Direccion", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 4, "Rodriguez", "809-123-5432", "Johan03@gmail.com", "Salcedo", new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(7513), "Johan", "809-543-2343" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Celular", "Correo", "Direccion", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 5, "Polanco", "809-654-2343", "Joel@gmail.com", "Tenares", new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(7528), "Joel", "809-098-4322" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Celular", "Correo", "Direccion", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 2, "Solorin", "809-123-4563", "Pedro@gmail.com", "Cenovi", new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(7476), "Pedro", "809-543-2344" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Celular", "Correo", "Direccion", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 3, "Gonzales", "809-233-2343", "Luis@gmail.com", "Porquero", new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(7497), "Luis", "809-654-2344" });

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "Codigo", "Nombre" },
                values: new object[] { 2, "Len-102", "Lengua Española" });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "Codigo", "Nombre" },
                values: new object[] { 3, "Prog'50", "Programacion" });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "Codigo", "Nombre" },
                values: new object[] { 4, "Bio'300", "Biologia" });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "Codigo", "Nombre" },
                values: new object[] { 5, "Qui'200", "Quimica" });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "Celular", "FechaIngreso", "FechaNacimiento", "Telefono" },
                values: new object[] { "809-123-3343", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5088), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5331), "849-234-1234" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolId", "Descripcion" },
                values: new object[] { 3, "Director" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolId", "Descripcion" },
                values: new object[] { 4, "Tecnico" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolId", "Descripcion" },
                values: new object[] { 5, "Supervisor" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Clave", "FechaCreacion", "Nombre", "NombreUsuario", "RolId" },
                values: new object[] { 2, "Lopez", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(8124), "Pedro", "PedroL", 2 });

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 2, 2, 2, new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 3, 3, 3, new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 4, 4, 4, new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 5, 5, 5, new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "ProfesorId", "Apellidos", "AreaId", "Celular", "Correo", "Direccion", "FechaIngreso", "FechaNacimiento", "Nombres", "Telefono" },
                values: new object[] { 2, "Villar", 2, "829-123-5432", "Juan@gmail.com", "Cenovi", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5914), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5915), "Juan", "829-098-5243" });

            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "ProfesorId", "Apellidos", "AreaId", "Celular", "Correo", "Direccion", "FechaIngreso", "FechaNacimiento", "Nombres", "Telefono" },
                values: new object[] { 3, "Villar", 3, "829-126-0156", "Jorgelis@gmail.com", "Tenares", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5934), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5935), "Jorgelis", "829-543-4421" });

            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "ProfesorId", "Apellidos", "AreaId", "Celular", "Correo", "Direccion", "FechaIngreso", "FechaNacimiento", "Nombres", "Telefono" },
                values: new object[] { 4, "Polanco", 4, "829-454-8567", "Mariam@gmail.com", "Salcedo", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(6017), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(6018), "Mariam", "829-123-0134" });

            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "ProfesorId", "Apellidos", "AreaId", "Celular", "Correo", "Direccion", "FechaIngreso", "FechaNacimiento", "Nombres", "Telefono" },
                values: new object[] { 5, "Estrella", 5, "829-0345-6422", "Maira@gmail.com", "Villa Tapia", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(6035), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(6036), "Maira", "829-345-1309" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Clave", "FechaCreacion", "Nombre", "NombreUsuario", "RolId" },
                values: new object[] { 3, "Santana", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(8145), "Miriam", "MiriamS", 3 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Clave", "FechaCreacion", "Nombre", "NombreUsuario", "RolId" },
                values: new object[] { 4, "Soto", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(8159), "Abelardo", "AbelardoS", 4 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Clave", "FechaCreacion", "Nombre", "NombreUsuario", "RolId" },
                values: new object[] { 5, "Cruz", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(8172), "Randis", "RandisC", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 29, 20, 11, 55, 0, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "Celular", "FechaIngreso", "FechaNacimiento", "Telefono" },
                values: new object[] { "890-123-3343", new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(6901), new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(7151), "908-234-1234" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 29, 20, 11, 55, 2, DateTimeKind.Local).AddTicks(37));
        }
    }
}
