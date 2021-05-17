namespace FascadePatternPractice
{
    public class TransactionManager
    {
        private readonly InventoryService _inventoryService = new();
        private readonly PaymentService _paymentService = new();
        private readonly ShippingService _shippingService = new();

        public Order PlaceOrder(Payment payment, Product product, Address address)
        {
            var order = new Order();
            order.Shipment = new Shipment {Address = address, Product = product};
            order.Payment = payment;
            _inventoryService.Add(product);
            _paymentService.Add(payment);
            _shippingService.Add(order.Shipment);

            return order;
        }
    }
}