using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class init0805 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFin",
                table: "Grabado",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicio",
                table: "Grabado",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "nombreCliente",
                table: "Grabado",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "precio",
                table: "Grabado",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "terminado",
                table: "Grabado",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaFin",
                table: "Grabado");

            migrationBuilder.DropColumn(
                name: "FechaInicio",
                table: "Grabado");

            migrationBuilder.DropColumn(
                name: "nombreCliente",
                table: "Grabado");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "Grabado");

            migrationBuilder.DropColumn(
                name: "terminado",
                table: "Grabado");
        }
    }
}
