using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReportApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Producto = table.Column<string>(type: "TEXT", nullable: true),
                    Monto = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "Id", "Fecha", "Monto", "Producto" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 2, 11, 5, 21, 40, 659, DateTimeKind.Local).AddTicks(8850), 25000m, "Laptop Gamer" },
                    { 2, new DateTime(2026, 2, 12, 5, 21, 40, 659, DateTimeKind.Local).AddTicks(8868), 800m, "Mouse Inalámbrico" },
                    { 3, new DateTime(2026, 2, 13, 5, 21, 40, 659, DateTimeKind.Local).AddTicks(8870), 7000m, "Monitor 4K" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
