using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IncripcionesWPF.Migrations
{
    public partial class AgregandoDetalleaprofesores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ProfesoresDetalle",
                columns: new[] { "ProfesorDetalleId", "MateriaId", "ProfesorId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "ProfesoresDetalle",
                columns: new[] { "ProfesorDetalleId", "MateriaId", "ProfesorId" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.InsertData(
                table: "ProfesoresDetalle",
                columns: new[] { "ProfesorDetalleId", "MateriaId", "ProfesorId" },
                values: new object[] { 2, 2, 1 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProfesoresDetalle",
                keyColumn: "ProfesorDetalleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProfesoresDetalle",
                keyColumn: "ProfesorDetalleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProfesoresDetalle",
                keyColumn: "ProfesorDetalleId",
                keyValue: 3);

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
    }
}
