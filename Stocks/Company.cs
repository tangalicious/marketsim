using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal StockPrice { get; set; }
        public string ThreeLetterAcronym { get; set; }
        public int Volatility { get; set; }
        public int UpdateSpeed { get; set; }

        public Company() { }
    }
}
