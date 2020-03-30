
using System;
using System.Collections.Generic;
using System.Text;
using Semana_1_Sesion_1.Entity;
namespace Semana_1_Sesion_1.Service
{
    public class TransactionService
    {
        public void MakeDeposit(decimal amount, DateTime date, string note, BankAccount bankAccount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),
                    "the deposit amount must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            bankAccount.AddTransaction(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note, BankAccount bankAccount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),
                    "the deposit withdrawal must be positive");
            }
            if (bankAccount.Balance - amount < 0)
            {
                throw new InvalidOperationException(
                    "There is not enough funds");
            }
            var withdrawal = new Transaction(-amount, date, note);
            bankAccount.AddTransaction(withdrawal);
        }
    }
}
