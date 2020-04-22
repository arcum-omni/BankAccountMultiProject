using System;

namespace BankAccountCore
{
    /// <summary>
    /// Represents an individual bank account:
    /// A very simple, non-realistic, example to showcase how a
    /// library ineracts with another project.
    /// </summary>
    public class Account
    {
        public Account(double initialBalance)
        {
            Balance = initialBalance;
        }

        /// <summary>
        /// The amount of money present in a financial repository, 
        /// at any given moment.
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// A sum of money placed into the account
        /// </summary>
        /// <param name="amt">a sum of money</param>
        public void Deposit(double amt)
        {
            Balance += amt;
        }
    }
}
