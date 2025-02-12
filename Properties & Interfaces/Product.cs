using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties___Interfaces
{
    internal class Product
    {

        #region Feilds
        private decimal price;
        private int stockQuantity;
        #endregion


        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsAvailable { get; set; }





    }
}
