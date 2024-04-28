namespace Maps.Persistence;

public class PMF_Map_Attribute
{
    public int ID { get; set; }
    public int PMF_MapID { get; set; }
    public PMF_Map PMF_Map { get; set; }
    public int PMF_Map_SectionID { get; set; }
    public PMF_Map_Section PMF_Map_Section { get; set; }
    public string Name { get; set; }
    public string Key { get; set; }
    public int KeyIdx { get; set; }
    public string Value { get; set; }
}
