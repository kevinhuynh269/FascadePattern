using System.Collections.Generic;
using System.Text;

namespace FascadePatternPractice
{
    public class ShippingService
    {
        private readonly List<Shipment> PendingShipments = new();

        public void Add(Shipment shipment)
        {
            PendingShipments.Add(shipment);
        }

        public void Remove(Shipment shipment)
        {
            PendingShipments.Remove(shipment);
        }

        // public List<Shipment> GetShipments
        // {
        //     get { return PendingShipments; }
        // }

        public string ListToString() {
            StringBuilder builder = new StringBuilder();
            foreach(var item in PendingShipments){
                builder.Append($"Address: {item.Address.ToString()} Product: {item.Product.ToString()} \n");
            }
            return builder.ToString();
        }
    }
}