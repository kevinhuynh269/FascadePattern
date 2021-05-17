using System.Collections.Generic;

namespace FascadePatternPractice
{
    public class PaymentService
    {
        List<Payment> PendingPayments = new();

        public void Add(Payment payment) => PendingPayments.Add(payment);
        public void Remove(Payment payment) => PendingPayments.Remove(payment);
    }
}