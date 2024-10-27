using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opgave_10_Entitity_Framework.Migrations
{
    /// <inheritdoc />
    public partial class AddNummerPladeField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NummerPlade",
                table: "Biler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Biler",
                keyColumn: "BILID",
                keyValue: -1,
                column: "NummerPlade",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NummerPlade",
                table: "Biler");
        }
    }
}
