using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Vehicle_Control_System
{
    internal class Motorcycle : Vehicle, ISwitchable
    {
        public string Name { set; get; }
        public string Model { set; get; }
        public int Year { set; get; }
        public decimal Price { set; get; }

        public override void Start()
        {
            Console.WriteLine("Start");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop");

        }

        public void SwitchOff()
        {
            Console.WriteLine("turn off");
        }

        public void SwitchOn()
        {
            Console.WriteLine("turn on");
        }
    }
    }
}
