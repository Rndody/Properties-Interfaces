using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class BankAccount
    {
        #region Properties
        public int AccountNumber { get; private set; }

        public string AccountHolderName { get; set; }

        public decimal Balance { get; private set; } 
        #endregion



        #region Constructors
        /* public BankAccount(int accountNumber, string accountHolderName, decimal balance)
         {
             AccountNumber = accountNumber;
             AccountHolderName = accountHolderName;
             Balance = balance;
         }*/
               
        public BankAccount(int accountNumber, string accountHolderName)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }
        #endregion


        #region Methods

        public void Deposit(decimal depositAmount)
        {
            Balance += depositAmount;     
        }
        public void Withdraw(decimal withdrawAmount) 
        {
            if (Balance >= withdrawAmount)
                Balance -= withdrawAmount;
            else 
                Console.WriteLine("plz check your balance available amount"); 
        }

        #endregion
    }
}
