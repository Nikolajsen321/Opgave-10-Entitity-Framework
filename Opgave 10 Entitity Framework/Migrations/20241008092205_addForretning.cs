using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opgave_10_Entitity_Framework.Migrations
{
    /// <inheritdoc />
    public partial class addForretning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forretning",
                columns: table => new
                {
                    ForretningID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forretning", x => x.ForretningID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forretning");
        }
    }
}
