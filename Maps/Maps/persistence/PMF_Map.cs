namespace Maps.Persistence;
public class PMF_Map
{
    public int ID { get; set; }
    public string FileName { get; set; }
    public byte[] Bytes { get; set; }
    public string Description { get; set; }
    
    public List<PMF_Map_Polyline> Polylines { get; set; }
    public List<PMF_Map_Polygon> Polygons { get; set; }
    public List<PMF_Map_POI> POIs { get; set; }
    public List<PMF_Map_Section> Sections { get; set; }

}

