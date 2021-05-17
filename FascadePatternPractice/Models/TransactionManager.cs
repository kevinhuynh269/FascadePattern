using System;

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

            // var GetProducts = _inventoryService.GetProducts;
            // var GetPayments = _paymentService.GetPayments;
            // var GetShipments = _shippingService.

            Console.WriteLine("Products:");
            Console.WriteLine(_inventoryService.ListToString());

            Console.WriteLine("Payment methods:");
            Console.WriteLine(_paymentService.ListToString());

            Console.WriteLine("Shipments:");
            Console.WriteLine(_shippingService.ListToString());
            

            return order;
        }
    }
}