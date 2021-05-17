using System.Collections.Generic;
using System.Text;

namespace FascadePatternPractice
{
    public class PaymentService
    {
        private readonly List<Payment> PendingPayments = new();

        public void Add(Payment payment)
        {
            PendingPayments.Add(payment);
        }

        public void Remove(Payment payment)
        {
            PendingPayments.Remove(payment);
        }

        // public List<Payment> GetPayments
        // {
        //     get { return PendingPayments; }
        // }

        public string ListToString(){
            StringBuilder builder = new StringBuilder();
            foreach(var item in PendingPayments){
                builder.Append($"{item.CardNum} + {item.ExpDate} + {item.CVV} + {item.CardName} + {item.BillingAddress} + \n");
            }
            return builder.ToString();
        }
    }
}