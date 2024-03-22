namespace Maps.Models
{
    public abstract class SectionBase
    {
        public virtual required string Identifier { get; set; }
        List<SectionFieldBase> Fields { get; set; } = new List<SectionFieldBase>();
    }
}
