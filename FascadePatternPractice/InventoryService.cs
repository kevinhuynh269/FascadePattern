using System.Collections.Generic;

namespace FascadePatternPractice
{
    public class InventoryService
    {
        private readonly List<Product> ProductInventory = new();
        public void Add(Product item) => ProductInventory.Add(item);
        public void Remove(Product item) => ProductInventory.Remove(item);

    }
}