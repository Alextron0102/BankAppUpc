using System;
using System.Collections.Generic;
using System.Text;
using Semana_1_Sesion_1.Service;

namespace Semana_1_Sesion_1.Entity
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in transactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private List<Transaction> transactions = new List<Transaction>();

        private static int accountNumbberSeed = 1234567890;
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumbberSeed.ToString();
            accountNumbberSeed++;
            this.Owner = name;
            AddTransaction(new Transaction(initialBalance, DateTime.Now, "Initial balance"));
        }
        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }
    }
}
