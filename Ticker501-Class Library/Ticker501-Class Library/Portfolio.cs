using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501_Class_Library
{
    public class Portfolio
    {
        List<Stock> _stock = new List<Stock>();
        List<int> _quantity = new List<int>();
        List<double> _prices = new List<double>();
        double _totalPositions = 0;
        string _name;

        /// <summary>
        /// Adds a new portfolio
        /// </summary>
        /// <param name="name"></param>
        public void AddPortfolio(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Adds stocks to the portfolio
        /// </summary>
        /// <param name="stock">The stock</param>
        /// <param name="quantity">The quantity purchased</param>
        public void AddStocks(Stock stock, int quantity)
        {
            _stock.Add(stock);
            _totalPositions += (stock.Price * quantity);
            _prices.Add(stock.Price * quantity);
            _quantity.Add(quantity);

        }

        /// <summary>
        /// This property returns the name of said portfolio.
        /// </summary>
        public string PortfolioName
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// This method returns a list of stocks in the portfolio
        /// </summary>
        /// <returns>List of stocks</returns>
        public List<Stock> GetStocks()
        {
            return _stock;
        }

        public Stock GetStock(string ticker)
        {
            for(int i = 0; i < _stock.Count; i++)
            {
                if(ticker == _stock[i].Ticker)
                {
                    return _stock[i];
                }
            }

            return null;

        }

        /// <summary>
        /// Returns the updated stock prices in portfolio
        /// </summary>
        /// <param name="percentage"></param>
        public void UpdateStocks(double percentage)
        {
            for (int i = 0; i < _stock.Count; i++)
            {
                double newPrice = _stock[i].Price * percentage;
                _stock[i].Price += newPrice;
            }

            _totalPositions += (_totalPositions * percentage);
        }

        /// <summary>
        /// Used to get the quatity of the stock purchased
        /// </summary>
        /// <param name="ticker"></param>
        /// <returns></returns>
        public int GetQuantity(string ticker)
        {
            for (int i = 0; i < _stock.Count; i++)
            {
               if(ticker == _stock[i].Ticker)
               {
                    return _quantity[i];
               }
            }

            return 0;
        }

        public double GetPriceOfSelectedStock(string ticker)
        {
            for (int i = 0; i < _stock.Count; i++)
            {
                if (ticker == _stock[i].Ticker)
                {
                    return _prices[i];
                }
            }

            return 0;
        }


    }
}
