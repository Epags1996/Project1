using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01WebApp.Models
{
    public interface Accounts
    {
        string AccountType { get; set; }
        int AccountID { get; set; }
        int CustomerID { get; set; }
        //double accountInterestRate { get; set; }
        int Balance { get; set; }

        void Transactions(Transaction newTrans);
    }
}
