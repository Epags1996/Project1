using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01WebApp.Models
{
    public class Term : Accounts
    {
        [Key]
        public int AccountID { get; set; }

        [Required]
        public int CustomerID { get; set; }


        [Required]
        public string AccountType { get; set; }

        [Required]
        public int Balance { get; set; }

        public DateTime accountCreated { get; set; }

        public List<Transaction> transList = new List<Transaction>();

        public void addTransactions(Transaction newTrans)
        {
            this.transList.Add(newTrans);
        }

        public List<Transaction> get()
        {
            return this.transList;
        }

        public void Transactions(Transaction newTrans)
        {
            throw new NotImplementedException();
        }
    }
}
