using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncripcionesWPF.Migrations
{
    public partial class Agregandolosotrosdetalles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CursosDetalle",
                columns: new[] { "CursoDetalleId", "CursoId", "MateriaId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "CursosDetalle",
                columns: new[] { "CursoDetalleId", "CursoId", "MateriaId" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "CursosDetalle",
                columns: new[] { "CursoDetalleId", "CursoId", "MateriaId" },
                values: new object[] { 3, 1, 3 });

            migrationBuilder.InsertData(
                table: "CursosDetalle",
                columns: new[] { "CursoDetalleId", "CursoId", "MateriaId" },
                values: new object[] { 4, 1, 4 });

            migrationBuilder.InsertData(
                table: "CursosDetalle",
                columns: new[] { "CursoDetalleId", "CursoId", "MateriaId" },
                values: new object[] { 5, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 824, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(6936));

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 5, 5, 5, new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 4, 4, 4, new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 3, 3, 3, new DateTime(2021, 12, 6, 20, 5, 37, 825, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(4571), new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(6113), new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(6148), new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(6176), new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(6201), new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.InsertData(
                table: "ProfesoresDetalle",
                columns: new[] { "ProfesorDetalleId", "MateriaId", "ProfesorId" },
                values: new object[] { 5, 5, 1 });

            migrationBuilder.InsertData(
                table: "ProfesoresDetalle",
                columns: new[] { "ProfesorDetalleId", "MateriaId", "ProfesorId" },
                values: new object[] { 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 826, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 827, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 827, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 827, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 5, 37, 827, DateTimeKind.Local).AddTicks(255));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CursosDetalle",
                keyColumn: "CursoDetalleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CursosDetalle",
                keyColumn: "CursoDetalleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CursosDetalle",
                keyColumn: "CursoDetalleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CursosDetalle",
                keyColumn: "CursoDetalleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CursosDetalle",
                keyColumn: "CursoDetalleId",
                keyValue: 5);

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
                table: "ProfesoresDetalle",
                keyColumn: "ProfesorDetalleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProfesoresDetalle",
                keyColumn: "ProfesorDetalleId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 678, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 678, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 678, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 678, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 678, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(5956), new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6846), new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6868), new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6941), new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6960), new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 20, 0, 24, 679, DateTimeKind.Local).AddTicks(9294));
        }
    }
}
