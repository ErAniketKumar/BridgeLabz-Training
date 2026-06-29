using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_IMP.Creational.Facade
{
    internal class PaymentFacade:Payment
    {
        Payment payment = new Payment();
        public void CompletePayment()
        {
            payment.Validate();
            payment.Save();
            payment.ReceiptEmial();
            Console.WriteLine("Payment Done!");
        }
    }
}
