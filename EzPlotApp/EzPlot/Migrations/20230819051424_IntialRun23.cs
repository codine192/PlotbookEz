using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EzPlot.Migrations
{
    public partial class IntialRun23 : Migration
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
                    PlotID = table.Column<int>(type: "int", nullable: false),
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
                    MarkerID = table.Column<int>(type: "int", nullable: false),
                    PlotbookID = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Plots_Markers_MarkerID",
                        column: x => x.MarkerID,
                        principalTable: "Markers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plots_PlotBooks_PlotbookID",
                        column: x => x.PlotbookID,
                        principalTable: "PlotBooks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    PlotID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Residents_Plots_PlotID",
                        column: x => x.PlotID,
                        principalTable: "Plots",
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
                name: "IX_Plots_MarkerID",
                table: "Plots",
                column: "MarkerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plots_PlotbookID",
                table: "Plots",
                column: "PlotbookID");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_PlotID",
                table: "Residents",
                column: "PlotID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "Plots");

            migrationBuilder.DropTable(
                name: "Markers");

            migrationBuilder.DropTable(
                name: "PlotBooks");

            migrationBuilder.DropTable(
                name: "Cemeteries");
        }
    }
}
