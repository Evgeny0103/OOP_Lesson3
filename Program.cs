using System;

namespace OOP_Lesson3
{
  public  class Program
    {
        static void Main(string[] args)
        {
            BankAccount _account1 = new BankAccount(4500M, accountType.depositAccounts);
            _account1.GetShow();
            Console.WriteLine("--------------------------");
            _account1.MoneyTransfer(ref _account1, 1500M);
            Console.WriteLine("Вывод информации после всех операций");
            _account1.GetShow();
            Console.WriteLine("Операции над 2 аккаунтом");
            BankAccount account2 = new BankAccount(10000M, accountType.budget);
            account2.GetShow();
            Console.WriteLine("--------------------------");
            account2.MoneyTransfer(ref account2, 5000M);
            Console.WriteLine("Вывод информации после всех операций");
            account2.GetShow();








        }

       
    }
}
