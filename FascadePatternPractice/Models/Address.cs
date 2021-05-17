namespace FascadePatternPractice
{
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{nameof(Address1)}: {Address1}, {nameof(Address2)}: {Address2}, {nameof(State)}: {State}, {nameof(ZipCode)}: {ZipCode}, {nameof(City)}: {City}";
        }
    }
}