using System;

namespace Lecture9Lab {
    class Program {
        static void Main(string[] args) {

            //cash payment variables and testing
            CashPayment cash1 = new CashPayment(12.53);
            CashPayment cash2 = new CashPayment();
            cash2.Amount = 812;

            Console.WriteLine(cash1.PaymentDetails());
            Console.WriteLine(cash2.PaymentDetails());

            //cc payment variables and testing
            CreditCardPayment credit1 = new CreditCardPayment("James Bond", 1234567890, 84.32);
            CreditCardPayment credit2 = new CreditCardPayment();
            credit2.Name = "Tom Cruise";
            credit2.CCNumber = 0987654321;
            credit2.Amount = 12.65;

            Console.WriteLine(credit1.PaymentDetails());
            Console.WriteLine(credit2.PaymentDetails());

        }
    }
}
