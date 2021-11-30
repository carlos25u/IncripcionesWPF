using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncripcionesWPF.Migrations
{
    public partial class ArreglandoDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 3,
                columns: new[] { "Codigo", "Nombre" },
                values: new object[] { "Elec-400", "Eletricidad" });

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
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 3,
                column: "Codigo",
                value: "Prog-50");

            migrationBuilder.UpdateData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 4,
                column: "Codigo",
                value: "Bio-300");

            migrationBuilder.UpdateData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 5,
                column: "Codigo",
                value: "Qui-200");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cursos",
                keyColumn: "CursoId",
                keyValue: 3,
                columns: new[] { "Codigo", "Nombre" },
                values: new object[] { "Con-400", "Contabilidad" });

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 517, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 5,
                column: "Fecha",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 3,
                column: "Codigo",
                value: "Prog'50");

            migrationBuilder.UpdateData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 4,
                column: "Codigo",
                value: "Bio'300");

            migrationBuilder.UpdateData(
                table: "Materias",
                keyColumn: "MateriaId",
                keyValue: 5,
                column: "Codigo",
                value: "Qui'200");

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5088), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5914), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5934), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(6017), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(6035), new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 11, 30, 10, 47, 47, 518, DateTimeKind.Local).AddTicks(8172));
        }
    }
}
