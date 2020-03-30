using System;
using Semana_1_Sesion_1.Common;
using Semana_1_Sesion_1.Entity;
using Semana_1_Sesion_1.Service;
namespace BankAppUpc
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Alexis", 1000);
            Console.WriteLine($"Account {account.Number} was create for {account.Owner} " + $"with {account.Balance} initial balance");

            //Retiro:
            var transactionService = new TransactionService();
            transactionService.MakeWithdrawal(500, DateTime.Now, "Rent pay", account);
            Console.WriteLine(account.Balance);
            //Deposito
            transactionService.MakeDeposit(380, DateTime.Now, "State Bonus", account);
            Console.WriteLine(account.Balance);

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
                

            var product = new Product
            {
                Id = 1,
                Name = "Electric Guitar",
                Status = Enums.Status.Disabled

            };
            //if(product.Status == Enums.Status.Disabled || product.Status == Enums.Status.Pending)
            if(ValidationHelper.ProductPendingOrDisabled(product.Status))
            {
                Console.WriteLine($"The current product is {product.Status}");
            }
        }
    }
}
