using System;
using CSharpPracticum.Common;
namespace CSharpPracticum.Tasks.Level2
{
    public class InsufficientFundsException : Exception { public InsufficientFundsException(string message) : base(message) { } }
    public class BankAccount
    {
        private decimal _balance;
        public decimal Balance { get { return _balance; } }
        public void Deposit(decimal amount) { if (amount <= 0) throw new ArgumentOutOfRangeException("amount"); _balance += amount; }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException("amount");
            if (amount > _balance) throw new InsufficientFundsException("Недостаточно средств на счёте.");
            _balance -= amount;
        }
    }
    public class Task30_BankAccount : TaskBase
    {
        public override string Title { get { return "30. Банковский счёт"; } }
        public override void Run()
        {
            BankAccount account = new BankAccount(); account.Deposit(500);
            Console.WriteLine("Баланс: " + account.Balance);
            try { account.Withdraw(700); }
            catch (InsufficientFundsException ex) { Console.WriteLine("Ошибка: " + ex.Message); }
            Console.WriteLine("Итоговый баланс: " + account.Balance);
        }
    }
}
