using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Customer_Notifications
{
    internal class Email:INotify
    {

        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }





        public void SendNotification()
        {
            Console.WriteLine($"Dear {UserName}\n {Message}");
        }
    }
}
