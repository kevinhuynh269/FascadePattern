namespace FascadePatternPractice
{
    public class Order
    {
        public Order(Payment payment, Shipment shipment)
        {
            Payment = payment;
            Shipment = shipment;
        }

        public Order()
        {
        }

        public Payment Payment { get; set; }
        public Shipment Shipment { get; set; }
    }
}