using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    enum AccountType
    {
        Saving, Checking
    }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private string holder;
        private int index;
        private readonly object get;

        public long Number { get { return accNo; } }
        public decimal Balance(){ return accBal; }
        public AccountType Type() { return accType; }
        public void Populate() { }
        public void Populate(long number, decimal balance)
        {
            accNo = number;
            accBal = balance;
            accType = AccountType.Checking;
        }
        public string Holder { get { return this.holder; } set { holder = value; } }
        public override String ToString()
        {
            // return ("AccountNumber: " + accNo + "Account Type: " +accType
            //  + "\nAccount Balance :"  +accBal);
            return ("Account's holder name: " + Holder + "\nAccount Number: " + accNo
            + "\nAccount Type: " + accType + "\nAccount Balance: " + accBal);
        }
        public string BankTransaction(int index){ _ = get; { return BankTransaction(99); } }
        public void Deposit(int i) { }
        public void Withdraw(int j) { }
        internal Queue Transactions(){ throw new NotImplementedException(); }
    }
    class CreateAccount
    {
        // private static object acc1;
        static void Main(string[] args)
        {
            BankAccount newAcc = new BankAccount();

            newAcc.Populate(123123123, 500);
            newAcc.Holder = "Japhet";
            Console.WriteLine("Account number is {0}", newAcc.Number);
            Console.WriteLine("Account balance is {0}", newAcc.Balance());
            Console.WriteLine("Account type is {0}", newAcc.Type());
            Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                newAcc.Deposit(100);
                newAcc.Withdraw(100);
            }
            Console.WriteLine(newAcc);
            Console.ReadLine();
            Console.WriteLine(newAcc);

        }
    }
}