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


        #region Properties
        public string Name { get; set; }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                    price = value;
            }
        }
        public int StockQuantity
        {
            get
            {
                return stockQuantity;
            }
            set
            {
                if (value >= 0)
                    stockQuantity = value;
                else stockQuantity = 0;
            }
        }
        public bool IsAvailable { get; set; }
        #endregion


        #region Constructors
        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            if (stock >= 0)
                StockQuantity = stock;
            else stock = 0;
        }
        #endregion



        #region Methods
        public void UpdateStock(int stockAdded, int stockDeducted)
        {
            if (stockAdded - stockDeducted + StockQuantity >= 0)
                StockQuantity = StockQuantity + stockAdded - stockDeducted;
        }
        #endregion





    }
}
