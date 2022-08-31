using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddStoredProcedure : Migration
    {
        private readonly string sp_GetUsers =
        @"CREATE OR ALTER PROCEDURE sp_GetUsers(
            @Titulo NVARCHAR(200))
        AS
        BEGIN
            SELECT * FROM Tarea 
        END";
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("9b025d3e-4862-4e84-8289-6140a1cae710"),
                column: "FechaCreacion",
                value: new DateTime(2022, 8, 31, 13, 40, 27, 34, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("9b025d3e-4862-4e84-8289-6140a1cae711"),
                columns: new[] { "Descripcion", "FechaCreacion", "Titulo" },
                values: new object[] { "Otra tarea", new DateTime(2022, 8, 31, 13, 40, 27, 34, DateTimeKind.Utc).AddTicks(9409), "Otra tarea" });

            migrationBuilder.Sql(sp_GetUsers);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("9b025d3e-4862-4e84-8289-6140a1cae710"),
                column: "FechaCreacion",
                value: new DateTime(2022, 8, 30, 16, 7, 53, 762, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("9b025d3e-4862-4e84-8289-6140a1cae711"),
                columns: new[] { "Descripcion", "FechaCreacion", "Titulo" },
                values: new object[] { "DARK", new DateTime(2022, 8, 30, 16, 7, 53, 762, DateTimeKind.Utc).AddTicks(2484), "Terminar de ver pelicula en Netflix" });
        }
    }
}
