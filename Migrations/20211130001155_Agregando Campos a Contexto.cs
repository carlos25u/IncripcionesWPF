using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncripcionesWPF.Migrations
{
    public partial class AgregandoCamposaContexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "Descripcion" },
                values: new object[] { 1, "Biologia" });

            migrationBuilder.InsertData(
                table: "Cursos",
                columns: new[] { "CursoId", "Codigo", "Nombre" },
                values: new object[] { 1, "Inf-200", "Informatica" });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteId", "Apellido", "Celular", "Correo", "Direccion", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[] { 1, "Lopez", "809-433-2344", "Carlos@gmail.com", "Villa tapia", new DateTime(2021, 11, 29, 20, 11, 55, 0, DateTimeKind.Local).AddTicks(8050), "Carlos", "809-887-3454" });

            migrationBuilder.InsertData(
                table: "Materias",
                columns: new[] { "MateriaId", "Codigo", "Nombre" },
                values: new object[] { 1, "Mat-302", "Matematicas" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 29, 20, 11, 55, 2, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 1, 1, 1, new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.InsertData(
                table: "Profesores",
                columns: new[] { "ProfesorId", "Apellidos", "AreaId", "Celular", "Correo", "Direccion", "FechaIngreso", "FechaNacimiento", "Nombres", "Telefono" },
                values: new object[] { 1, "Lopez", 1, "890-123-3343", "Johan@gmail.com", "Cenovi", new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(6901), new DateTime(2021, 11, 29, 20, 11, 55, 1, DateTimeKind.Local).AddTicks(7151), "Johan", "908-234-1234" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "AreaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 29, 16, 13, 8, 446, DateTimeKind.Local).AddTicks(1829));
        }
    }
}
