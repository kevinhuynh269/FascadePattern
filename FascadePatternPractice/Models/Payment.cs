namespace FascadePatternPractice
{
    public class Payment
    {
        public string CardNum { get; set; }
        public string ExpDate { get; set; }
        public int CVV { get; set; }
        public string CardName { get; set; }
        public Address BillingAddress { get; set; }
    }
}