using System;

namespace FascadePatternPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TransactionManager manager = new TransactionManager();

            Address add1 = new Address { Address1 = "123 Main St.", Address2 = "", State = "Illinois", ZipCode = 12345, City = "Midlothian" };
            Payment pay1 = new Payment { CardNum = "1111222233334444", ExpDate = "04/2024", CVV = 123, CardName = "Master Card", BillingAddress = add1 };
            Product prod1 = new Product { Name = "Doggie toy", Pricing = 3.45M, Quantity = 2 };

            manager.PlaceOrder(pay1, prod1, add1);
        }
    }
}