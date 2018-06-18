using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    public class Transaction
    {
        public int ID { get; set; }
        public Boolean IsBuy { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public int ShareAmount { get; set; }
        public decimal SharePrice { get; set; }
        public decimal TransactionTotal { get; set; }
        public virtual User User { get; set; }
        public virtual Company Company { get; set; }

        public Transaction() { }

    }
}
