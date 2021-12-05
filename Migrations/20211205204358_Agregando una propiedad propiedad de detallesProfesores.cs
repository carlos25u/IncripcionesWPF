using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncripcionesWPF.Migrations
{
    public partial class AgregandounapropiedadpropiedaddedetallesProfesores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 916, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6073), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6905), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6932), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6949), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6966), new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 16, 43, 57, 917, DateTimeKind.Local).AddTicks(9434));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 393, DateTimeKind.Local).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 393, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 393, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 393, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 393, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(6224), new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(7212), new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(7232), new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(7247), new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(7261), new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 51, 5, 394, DateTimeKind.Local).AddTicks(9517));
        }
    }
}
