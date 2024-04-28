namespace Maps.Persistence;

public class PMF_Map_Section
{
    public int ID { get; set; }
    public int PMF_MapID { get; set; }
    public PMF_Map PMF_Map { get; set; }
    public string Type { get; set; } = "";
    public string Name { get; set; } = "";
    public int FileSectionNumber { get; set; }
    public List<PMF_Map_Attribute> Attributes { get; set; } = [];
    public List<PMF_Map_Polygon> Polygons { get; set; } = [];
    public List<PMF_Map_Polyline> Polylines { get; set; } = [];
    public List<PMF_Map_POI> POIs { get; set; } = [];
}

