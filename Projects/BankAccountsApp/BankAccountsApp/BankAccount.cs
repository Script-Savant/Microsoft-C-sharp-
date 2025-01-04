using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp 
{
    public class BankAccount(string owner)
    {
        public string Owner { get; set; } = owner;
        public Guid AccountNumber { get; set; } = Guid.NewGuid();
        public decimal Balance { get; protected set; } = 0;

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return $"You can not deposit ${amount}.";
            if (amount > 20000)
                return "AML Deposit Limit Reached.";

            Balance += amount;
            return "Deposit completed successfully.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return $"You can not withdraw ${amount}.";
            if (amount >= 10000)
                return "AML Deposit Limit Reached";
            if (amount > Balance)
                return $"You do not have enough money in your account to withdraw ${amount}. Your account balace is ${Balance}.";

            Balance -= amount;
            return $"You have successfully withdrawn {amount}.";
        }

    }

}
