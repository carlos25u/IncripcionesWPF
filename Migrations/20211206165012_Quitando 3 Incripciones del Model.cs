using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncripcionesWPF.Migrations
{
    public partial class Quitando3IncripcionesdelModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 203, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 203, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 203, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 203, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 203, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 203, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 203, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(1110), new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(2000), new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(2024), new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(2040), new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(2055), new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 6, 12, 50, 12, 204, DateTimeKind.Local).AddTicks(4753));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 2,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 3,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 4,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Estudiantes",
                keyColumn: "EstudianteId",
                keyValue: 5,
                column: "FechaNacimiento",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 554, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "Incripciones",
                keyColumn: "IncripcionId",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 3, 3, 3, new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 4, 4, 4, new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.InsertData(
                table: "Incripciones",
                columns: new[] { "IncripcionId", "CursoId", "EstudianteId", "Fecha" },
                values: new object[] { 5, 5, 5, new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 1,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(4971), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 2,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5812), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 3,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5835), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 4,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5852), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Profesores",
                keyColumn: "ProfesorId",
                keyValue: 5,
                columns: new[] { "FechaIngreso", "FechaNacimiento" },
                values: new object[] { new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5867), new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5,
                column: "FechaCreacion",
                value: new DateTime(2021, 12, 5, 17, 17, 26, 555, DateTimeKind.Local).AddTicks(8150));
        }
    }
}
