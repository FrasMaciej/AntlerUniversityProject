using NetTopologySuite.Geometries;

namespace Maps.Persistence;

public class PMF_Map_Polyline
{
    public int ID { get; set; }
    public int PMF_MapID { get; set; }
    public PMF_Map PMF_Map { get; set; }
    public string Name { get; set; } = "";
    public int Start_level { get; set; }
    public int End_level { get; set; }
    public string Key { get; set; } = "";
    public int? KeyIdx { get; set; }
    //public Geometry Geometry { get; set; }
    //[Column(TypeName = "geometry (linestring)")]
    public LineString? LineString { get; set; }
}
