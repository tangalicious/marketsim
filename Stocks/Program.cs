using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    class Program
    {
        static void Main(string[] args)
        {
            StockDBContext db = new StockDBContext();
            User user = new User
            {
                Name = "Chris",
                UserName = "Tangalicious",
                PassWord = "Fresh123",
                Balance = 1000m
            };
            db.Users.Add(user);
            db.SaveChanges();

        }
    }
}
