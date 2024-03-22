namespace Maps.Models
{
    public class SectionFieldIdx : SectionFieldBase
    {
        public override required string Identifier 
        {   
            get
            {
                return $"{IdentifierPart}{Index}";
            }
            set
            {
                var firstDigit = value.IndexOf(value.FirstOrDefault(c => char.IsDigit(c)));
                if (firstDigit == -1) throw new ArgumentException("Identifier id not provided");
                IdentifierPart = value.Substring(Index, firstDigit);
                var number = value.Substring(firstDigit);
                if(int.TryParse(number, out int result))
                {
                    Index = result;
                }
                else
                {
                    throw new ArgumentException("Index is not a number");
                }
            } 
        }
        public required string IdentifierPart { get; set; }
        public required int Index { get; set; }
        public required string Value { get; set; }

    }
}
