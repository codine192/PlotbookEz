using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EzPlot.Migrations
{
    public partial class InitialRun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cemeteries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cemeteries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Markers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeathDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedToPlot = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PlotBooks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CemeteryID = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlotBooks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlotBooks_Cemeteries_CemeteryID",
                        column: x => x.CemeteryID,
                        principalTable: "Cemeteries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plots",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentID = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    PlotBookID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Plots_PlotBooks_PlotBookID",
                        column: x => x.PlotBookID,
                        principalTable: "PlotBooks",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Plots_Residents_ResidentID",
                        column: x => x.ResidentID,
                        principalTable: "Residents",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cemeteries",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Miskellys Place" });

            migrationBuilder.InsertData(
                table: "Cemeteries",
                columns: new[] { "ID", "Name" },
                values: new object[] { 2, "Cemetery B" });

            migrationBuilder.CreateIndex(
                name: "IX_PlotBooks_CemeteryID",
                table: "PlotBooks",
                column: "CemeteryID");

            migrationBuilder.CreateIndex(
                name: "IX_Plots_PlotBookID",
                table: "Plots",
                column: "PlotBookID");

            migrationBuilder.CreateIndex(
                name: "IX_Plots_ResidentID",
                table: "Plots",
                column: "ResidentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Markers");

            migrationBuilder.DropTable(
                name: "Plots");

            migrationBuilder.DropTable(
                name: "PlotBooks");

            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "Cemeteries");
        }
    }
}
