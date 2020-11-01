using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture9Lab {
    class Payment {

        //instance variables
        public double Amount { get; set; }

        //constructors
        public Payment() { }
        public Payment(double amount) {
            Amount = amount;
        }

        /// <summary>
        /// get amount paid
        /// </summary>
        /// <returns>amount paid in a string</returns>
        public string PaymentDetails() {
            return "The amount you paid was " + Amount;
        }

    }
}
