using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Maps.Migrations
{
    /// <inheritdoc />
    public partial class Basicefmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.CreateTable(
                name: "PMF_Map",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileName = table.Column<string>(type: "text", nullable: false),
                    Bytes = table.Column<byte[]>(type: "bytea", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMF_Map", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PMF_Map_Attributes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PMF_MapID = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMF_Map_Attributes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PMF_Map_Attributes_PMF_Map_PMF_MapID",
                        column: x => x.PMF_MapID,
                        principalTable: "PMF_Map",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PMF_Map_POIs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PMF_MapID = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Point = table.Column<Point>(type: "geometry", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMF_Map_POIs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PMF_Map_POIs_PMF_Map_PMF_MapID",
                        column: x => x.PMF_MapID,
                        principalTable: "PMF_Map",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PMF_Map_Polygons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PMF_MapID = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Polygon = table.Column<Polygon>(type: "geometry", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMF_Map_Polygons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PMF_Map_Polygons_PMF_Map_PMF_MapID",
                        column: x => x.PMF_MapID,
                        principalTable: "PMF_Map",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PMF_Map_Polylines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PMF_MapID = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Start_level = table.Column<int>(type: "integer", nullable: false),
                    End_level = table.Column<int>(type: "integer", nullable: false),
                    LineString = table.Column<LineString>(type: "geometry", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMF_Map_Polylines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PMF_Map_Polylines_PMF_Map_PMF_MapID",
                        column: x => x.PMF_MapID,
                        principalTable: "PMF_Map",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_Attributes_PMF_MapID",
                table: "PMF_Map_Attributes",
                column: "PMF_MapID");

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_POIs_PMF_MapID",
                table: "PMF_Map_POIs",
                column: "PMF_MapID");

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_Polygons_PMF_MapID",
                table: "PMF_Map_Polygons",
                column: "PMF_MapID");

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_Polylines_PMF_MapID",
                table: "PMF_Map_Polylines",
                column: "PMF_MapID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PMF_Map_Attributes");

            migrationBuilder.DropTable(
                name: "PMF_Map_POIs");

            migrationBuilder.DropTable(
                name: "PMF_Map_Polygons");

            migrationBuilder.DropTable(
                name: "PMF_Map_Polylines");

            migrationBuilder.DropTable(
                name: "PMF_Map");
        }
    }
}
