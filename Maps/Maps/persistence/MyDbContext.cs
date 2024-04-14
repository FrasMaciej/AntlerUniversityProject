using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using System.Reflection.Emit;

namespace Maps.Persistence;
public class MyDbContext : DbContext
{
    public DbSet<PMF_Map> Maps { get; set; }
    public DbSet<PMF_Map_Attributes> MapAttributes { get; set; }
    public DbSet<PMF_Map_Polyline> MapPolylines { get; set; }
    public DbSet<PMF_Map_Polygon> MapPolygons { get; set; }
    public DbSet<PMF_Map_POI> MapPOIs { get; set; }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Data Source=127.0.0.1;Initial Catalog=postgis"
            , x => x.UseNetTopologySuite());
            
        }
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension("postgis");

        modelBuilder.Entity<PMF_Map>().ToTable("PMF_Map");
        modelBuilder.Entity<PMF_Map_Attributes>().ToTable("PMF_Map_Attributes");
        modelBuilder.Entity<PMF_Map_Polyline>().ToTable("PMF_Map_Polylines");
        modelBuilder.Entity<PMF_Map_Polygon>().ToTable("PMF_Map_Polygons");
        modelBuilder.Entity<PMF_Map_POI>().ToTable("PMF_Map_POIs");

        //modelBuilder.Entity<PMF_Map_Polyline>().Property(p => p.LineString).HasColumnType("geometry").HasConversion(new LineStringConverter());//.HasConversion(p => p != null ? p.AsText() : null, s => ParseLineString(s));
        //modelBuilder.Entity<PMF_Map_Polygon>().Property(p => p.Polygon).HasColumnType("geometry (polygon)");//.HasConversion(p=>p != null ? p.AsText() : null, s => ParsePolygon(s));
        //modelBuilder.Entity<PMF_Map_POI>().Property(p => p.Point).HasColumnType("geometry (point)");//.HasConversion(p => p != null ? p.AsText() : null, s => ParsePoint(s));

        modelBuilder.Entity<PMF_Map_Attributes>().HasOne(a => a.PMF_Map).WithMany().HasForeignKey(a => a.PMF_MapID);
        //modelBuilder.Entity<PMF_Map_Polyline>().HasOne(p => p.PMF_Map).WithMany(m=>m.Polylines).HasForeignKey(p => p.PMF_MapID);
        //modelBuilder.Entity<PMF_Map_Polygon>().HasOne(p => p.PMF_Map).WithMany(m=>m.Polygons).HasForeignKey(p => p.PMF_MapID);
        modelBuilder.Entity<PMF_Map_POI>().HasOne(p => p.PMF_Map).WithMany(m=>m.POIs).HasForeignKey(p => p.PMF_MapID);


        
        base.OnModelCreating(modelBuilder);
    }

    // Method to parse Well-Known Text (WKT) into Point
    private static Point? ParsePoint(string s)
    {
        if(string.IsNullOrEmpty(s)) return null;
        var coordinates = s.Trim('(', ')').Split(' ');
        return new Point(double.Parse(coordinates[0]), double.Parse(coordinates[1]));
    }

    // Method to parse Well-Known Text (WKT) into Polygon
    private static Polygon? ParsePolygon(string s)
    {
        if(string.IsNullOrEmpty(s)) return null;
        var coordinates = s.Trim('(', ')').Split(',');
        var points = new Coordinate[coordinates.Length];
        for (int i = 0; i < coordinates.Length; i++)
        {
            var xy = coordinates[i].Trim().Split(' ');
            points[i] = new Coordinate(double.Parse(xy[0]), double.Parse(xy[1]));
        }
        return new Polygon(new LinearRing(points));
    }

    // Method to parse Well-Known Text (WKT) into LineString
    private static LineString? ParseLineString(string s)
    {
        if(string.IsNullOrEmpty(s)) return null;
        var coordinates = s.Trim('(', ')').Split(',');
        var points = new Coordinate[coordinates.Length];
        for (int i = 0; i < coordinates.Length; i++)
        {
            var xy = coordinates[i].Trim().Split(' ');
            points[i] = new Coordinate(double.Parse(xy[0]), double.Parse(xy[1]));
        }
        return new LineString(points);
    }
}


public class LineStringConverter : ValueConverter<LineString, Geometry>
{
    public LineStringConverter() : base(
        l => ConvertToString(l),
        s => ConvertToLineString(s))
    {
    }

    private static Geometry ConvertToString(LineString lineString)
    {
        // Convert LineString to WKT (Well Known Text) format
        //return lineString?.AsText();
        return lineString as Geometry;
    }

    private static LineString ConvertToLineString(object value)
    {
        // Convert WKT string to LineString
        return value as LineString;
    }
}