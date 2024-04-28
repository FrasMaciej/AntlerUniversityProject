using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace Maps.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<LineString>(
                name: "LineString",
                table: "PMF_Map_Polylines",
                type: "geometry",
                nullable: true,
                oldClrType: typeof(LineString),
                oldType: "geometry");

            migrationBuilder.AlterColumn<Polygon>(
                name: "Polygon",
                table: "PMF_Map_Polygons",
                type: "geometry",
                nullable: true,
                oldClrType: typeof(Polygon),
                oldType: "geometry");

            migrationBuilder.AlterColumn<Point>(
                name: "Point",
                table: "PMF_Map_POIs",
                type: "geometry",
                nullable: true,
                oldClrType: typeof(Point),
                oldType: "geometry");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<LineString>(
                name: "LineString",
                table: "PMF_Map_Polylines",
                type: "geometry",
                nullable: false,
                oldClrType: typeof(LineString),
                oldType: "geometry",
                oldNullable: true);

            migrationBuilder.AlterColumn<Polygon>(
                name: "Polygon",
                table: "PMF_Map_Polygons",
                type: "geometry",
                nullable: false,
                oldClrType: typeof(Polygon),
                oldType: "geometry",
                oldNullable: true);

            migrationBuilder.AlterColumn<Point>(
                name: "Point",
                table: "PMF_Map_POIs",
                type: "geometry",
                nullable: false,
                oldClrType: typeof(Point),
                oldType: "geometry",
                oldNullable: true);
        }
    }
}
