using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture9Lab {
    class CreditCardPayment : Payment {

        //instance variables
        public string Name { get; set; }
        public int CCNumber { get; set; }

        //constructors
        public CreditCardPayment() { }
        public CreditCardPayment(string name, int ccNumber, double amount) {
            Name = name;
            CCNumber = ccNumber;
            Amount = amount;
        }

        /// <summary>
        /// get amount paid with CC info
        /// </summary>
        /// <returns>string with amount paid</returns>
        public new string PaymentDetails() {
            return "The amount you paid in credit was " + Amount + "\nCard Info: " + CCNumber + " " + Name;
        }

    }
}
