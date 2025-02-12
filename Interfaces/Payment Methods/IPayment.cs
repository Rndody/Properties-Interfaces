using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Payment_Methods
{
    internal interface IPayment
    {
            public string Payment(decimal amount);

        
    }
}
