using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedVentas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2026, 2, 11, 5, 21, 55, 928, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2026, 2, 12, 5, 21, 55, 928, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2026, 2, 13, 5, 21, 55, 928, DateTimeKind.Local).AddTicks(7789));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2026, 2, 11, 5, 21, 40, 659, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2026, 2, 12, 5, 21, 40, 659, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2026, 2, 13, 5, 21, 40, 659, DateTimeKind.Local).AddTicks(8870));
        }
    }
}
