using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Payment_Methods
{
    internal class CreditCardPayment : IPayment
    {


        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { private get; set; }
        public decimal Balance { get; set; }
        public int CardNumber { get; set; }



        public string Payment(decimal amount)
        {
            if (amount >= Balance)
                Balance -= amount;
            return $"Card Number: {CardNumber} paied {amount} and balance now ={Balance}";
        }
    }
}
