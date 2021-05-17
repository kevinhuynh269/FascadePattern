namespace FascadePatternPractice
{
    public class Payment
    {
        public int CardNum { get; set; }
        public int ExpDate { get; set; }
        public int CVV  { get; set; }
        public string CardName { get; set; }
        public Address BillingAddress { get; set; }
    }
}