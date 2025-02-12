using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Car
    {
        #region Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Year;
            }
        }
        #endregion


        #region Constructors
        public Car(string make, string model, int year, int mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = 0;
        }
        #endregion


        #region Methods

        public void Drive(int distance)
        {
            if (distance >= 0) 
            Mileage += distance;
        } 
        #endregion




    }
}
