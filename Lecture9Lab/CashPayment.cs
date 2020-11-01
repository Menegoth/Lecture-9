using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture9Lab {
    class CashPayment : Payment {

        //constructors
        public CashPayment() { }
        public CashPayment(double amount) {
            Amount = amount;
        }

        /// <summary>
        /// get amount paid
        /// </summary>
        /// <returns>amount paid as string</returns>
        public new string PaymentDetails() {
            return "The amount you paid in cash was " + Amount;
        }

    }
}
