using System.Collections.Generic;
using System.Text;

namespace FascadePatternPractice
{
    public class InventoryService
    {
        private readonly List<Product> ProductInventory = new();

        public void Add(Product item)
        {
            ProductInventory.Add(item);
        }

        public void Remove(Product item)
        {
            ProductInventory.Remove(item);
        }

        // public string GetProducts
        // {
        //     get { return ProductInventory; }
        // }

        public string ListToString(){
            StringBuilder builder = new StringBuilder();
            foreach(var item in ProductInventory){
                builder.Append($"Item: {item.Name} Quantity: {item.Quantity} Pricing: {item.Pricing} Total Price: {item.Quantity * item.Pricing} + \n");
            }
            return builder.ToString();
        }
    }
}