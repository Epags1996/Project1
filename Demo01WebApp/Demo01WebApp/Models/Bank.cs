using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo01WebApp.Models;

namespace Demo01WebApp.Models
{
    public class Bank : DbContext
    {
        public Bank(DbContextOptions<Bank> options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Checking> Checking { get; set; }
        public DbSet<Business> Business { get; set; }
        //public DbSet<Term> Term { get; set; }
        public DbSet<Loan> Loan { get; set; }
        //public DbSet<Term> Term { get; set; }
        public DbSet<Demo01WebApp.Models.Term> Term { get; set; }

        //public DbSet<Transaction> Transaction { get; set; }
    }
}
