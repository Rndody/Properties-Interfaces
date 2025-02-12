using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Payment_Methods
{
    internal class PaymentMethod
    {
        private IPayment payment;


        public IPayment Payment
        {
            private get
            { return payment; }
            set
            { payment = value; }
        }

       /// //// ?!

    }
}
