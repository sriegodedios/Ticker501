using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_Class_Library
{
    public class Stock
    {
        private string _ticker;
        private string _name;
        private double _price;
        
        /// <summary>
        /// This constuctor initializes the fields for the stock
        /// </summary>
        /// <param name="ticker">The ticker information</param>
        /// <param name="name">The name of the company</param>
        /// <param name="price">The price of the stock.</param>
        public Stock(string ticker, string name, double price)
        {
            _ticker = ticker;
            _name = name;
            _price = price;

        }
        
        /// <summary>
        /// This property returns the Ticker ID of the stock.
        /// </summary>
        public string Ticker
        {
            get
            {
                return _ticker;
            }
        }

        /// <summary>
        /// This property returns the Company name of the stock.
        /// </summary>
        public string Company
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// This property returns the current Price of the stock.
        /// </summary>
        public double Price
        {
            get
            {
                return _price;
            }set
            {
                _price = value;
            }
        }



    }
}
