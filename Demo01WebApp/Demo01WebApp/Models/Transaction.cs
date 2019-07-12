using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01WebApp.Models
{
    public class Transaction
    {
        public string AccountType { get; set; }
        public int AccountID { get; set; }
        public int CustomerID { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Type { get; set; }

    }
}
