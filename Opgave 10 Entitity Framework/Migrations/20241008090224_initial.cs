using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Opgave_10_Entitity_Framework.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.CreateTable(
        //        name: "Ejer",
        //        columns: table => new
        //        {
        //            EjerID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Navn = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Ejer", x => x.EjerID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Biler",
        //        columns: table => new
        //        {
        //            BILID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Weight = table.Column<int>(type: "int", nullable: false),
        //            Årstal = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            EjerID = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Biler", x => x.BILID);
        //            table.ForeignKey(
        //                name: "FK_Biler_Ejer_EjerID",
        //                column: x => x.EjerID,
        //                principalTable: "Ejer",
        //                principalColumn: "EjerID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.InsertData(
        //        table: "Ejer",
        //        columns: new[] { "EjerID", "Navn" },
        //        values: new object[] { -1, "Hans" });

        //    migrationBuilder.InsertData(
        //        table: "Biler",
        //        columns: new[] { "BILID", "EjerID", "Name", "Weight", "Årstal" },
        //        values: new object[] { -1, -1, "Ford", 1400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Biler_EjerID",
        //        table: "Biler",
        //        column: "EjerID");
         }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biler");

            migrationBuilder.DropTable(
                name: "Ejer");
        }
    }
}
