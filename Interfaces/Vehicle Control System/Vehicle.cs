using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Vehicle_Control_System
{
    internal abstract class Vehicle
    {
        private  string name;
        private string model;
        private int year;
        private decimal price;



        public abstract void Start();
        public abstract void Stop();
    }
}
