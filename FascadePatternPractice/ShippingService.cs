using System.Collections.Generic;

namespace FascadePatternPractice {
    public class ShippingService {
        List<Shipment> PendingShipments = new();

        public void Add(Shipment shipment) => PendingShipments.Add(shipment);

        public void Remove(Shipment shipment) => PendingShipments.Remove(shipment);
    }
}