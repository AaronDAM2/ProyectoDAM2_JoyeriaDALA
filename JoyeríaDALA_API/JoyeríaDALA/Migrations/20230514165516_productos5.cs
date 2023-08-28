using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoyeríaDALA.Migrations
{
    /// <inheritdoc />
    public partial class productos5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "stock",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "stock",
                table: "Producto");
        }
    }
}
