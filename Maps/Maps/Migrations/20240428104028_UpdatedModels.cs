using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Maps.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "PMF_Map_Polylines",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KeyIdx",
                table: "PMF_Map_Polylines",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PMF_Map_SectionID",
                table: "PMF_Map_Polylines",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "PMF_Map_Polygons",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KeyIdx",
                table: "PMF_Map_Polygons",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PMF_Map_SectionID",
                table: "PMF_Map_Polygons",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "PMF_Map_POIs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KeyIdx",
                table: "PMF_Map_POIs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PMF_Map_SectionID",
                table: "PMF_Map_POIs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "PMF_Map_Attributes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KeyIdx",
                table: "PMF_Map_Attributes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PMF_Map_SectionID",
                table: "PMF_Map_Attributes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PMF_Map_Sections",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PMF_MapID = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FileSectionNumber = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PMF_Map_Sections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PMF_Map_Sections_PMF_Map_PMF_MapID",
                        column: x => x.PMF_MapID,
                        principalTable: "PMF_Map",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_Polylines_PMF_Map_SectionID",
                table: "PMF_Map_Polylines",
                column: "PMF_Map_SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_Polygons_PMF_Map_SectionID",
                table: "PMF_Map_Polygons",
                column: "PMF_Map_SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_POIs_PMF_Map_SectionID",
                table: "PMF_Map_POIs",
                column: "PMF_Map_SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_Attributes_PMF_Map_SectionID",
                table: "PMF_Map_Attributes",
                column: "PMF_Map_SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_PMF_Map_Sections_PMF_MapID",
                table: "PMF_Map_Sections",
                column: "PMF_MapID");

            migrationBuilder.AddForeignKey(
                name: "FK_PMF_Map_Attributes_PMF_Map_Sections_PMF_Map_SectionID",
                table: "PMF_Map_Attributes",
                column: "PMF_Map_SectionID",
                principalTable: "PMF_Map_Sections",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PMF_Map_POIs_PMF_Map_Sections_PMF_Map_SectionID",
                table: "PMF_Map_POIs",
                column: "PMF_Map_SectionID",
                principalTable: "PMF_Map_Sections",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PMF_Map_Polygons_PMF_Map_Sections_PMF_Map_SectionID",
                table: "PMF_Map_Polygons",
                column: "PMF_Map_SectionID",
                principalTable: "PMF_Map_Sections",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PMF_Map_Polylines_PMF_Map_Sections_PMF_Map_SectionID",
                table: "PMF_Map_Polylines",
                column: "PMF_Map_SectionID",
                principalTable: "PMF_Map_Sections",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PMF_Map_Attributes_PMF_Map_Sections_PMF_Map_SectionID",
                table: "PMF_Map_Attributes");

            migrationBuilder.DropForeignKey(
                name: "FK_PMF_Map_POIs_PMF_Map_Sections_PMF_Map_SectionID",
                table: "PMF_Map_POIs");

            migrationBuilder.DropForeignKey(
                name: "FK_PMF_Map_Polygons_PMF_Map_Sections_PMF_Map_SectionID",
                table: "PMF_Map_Polygons");

            migrationBuilder.DropForeignKey(
                name: "FK_PMF_Map_Polylines_PMF_Map_Sections_PMF_Map_SectionID",
                table: "PMF_Map_Polylines");

            migrationBuilder.DropTable(
                name: "PMF_Map_Sections");

            migrationBuilder.DropIndex(
                name: "IX_PMF_Map_Polylines_PMF_Map_SectionID",
                table: "PMF_Map_Polylines");

            migrationBuilder.DropIndex(
                name: "IX_PMF_Map_Polygons_PMF_Map_SectionID",
                table: "PMF_Map_Polygons");

            migrationBuilder.DropIndex(
                name: "IX_PMF_Map_POIs_PMF_Map_SectionID",
                table: "PMF_Map_POIs");

            migrationBuilder.DropIndex(
                name: "IX_PMF_Map_Attributes_PMF_Map_SectionID",
                table: "PMF_Map_Attributes");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "PMF_Map_Polylines");

            migrationBuilder.DropColumn(
                name: "KeyIdx",
                table: "PMF_Map_Polylines");

            migrationBuilder.DropColumn(
                name: "PMF_Map_SectionID",
                table: "PMF_Map_Polylines");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "PMF_Map_Polygons");

            migrationBuilder.DropColumn(
                name: "KeyIdx",
                table: "PMF_Map_Polygons");

            migrationBuilder.DropColumn(
                name: "PMF_Map_SectionID",
                table: "PMF_Map_Polygons");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "PMF_Map_POIs");

            migrationBuilder.DropColumn(
                name: "KeyIdx",
                table: "PMF_Map_POIs");

            migrationBuilder.DropColumn(
                name: "PMF_Map_SectionID",
                table: "PMF_Map_POIs");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "PMF_Map_Attributes");

            migrationBuilder.DropColumn(
                name: "KeyIdx",
                table: "PMF_Map_Attributes");

            migrationBuilder.DropColumn(
                name: "PMF_Map_SectionID",
                table: "PMF_Map_Attributes");
        }
    }
}
