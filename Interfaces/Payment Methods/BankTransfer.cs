using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Payment_Methods
{
    internal class BankTransfer : IPayment
    {


        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { private get; set; }
        public decimal Balance { get; set; }



        public string Payment(decimal amount)
        {
            if (amount >= Balance)
                Balance -= amount;
            return $"{amount} is transfered Successfully ";
        }
    }
}
