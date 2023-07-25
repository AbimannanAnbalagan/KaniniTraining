using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    public class BankTransactions
    {
        private int custid;
        private long accountNumber;
        private string accountHolderName,status;
        private decimal balance, creditAmount , debitAmount;



        public int Custid { get => custid; set => custid = value; }
        public long AccountNumber { get => accountNumber; set => accountNumber = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }
        public decimal CreditAmount { get => creditAmount; set => creditAmount = value; }
        public BankTransactions(int cid , long accNo , string accHN , decimal bal) 
        {
            Custid = cid; 
            AccountNumber = accNo;
            accountHolderName= accHN;
            Status = "inactive";
            creditAmount = debitAmount = 0;
            Balance = bal;

        }

        
         internal decimal performTransactions()
        {
            Console.WriteLine("Press 1 For Credit \nPress 2 For Debit");
            int ch = Convert.ToInt32( Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Credit Amount");
                    creditAmount = Convert.ToDecimal(Console.ReadLine());
                    Balance += creditAmount;
                    Status = "Active";
                    break;
                case 2:
                    Console.WriteLine("Enter debit Amount");
                    debitAmount = Convert.ToDecimal(Console.ReadLine());
                    Balance -= debitAmount;
                    Status = "Active";
                    break;
                default:
                    Console.WriteLine("Entered a wrong key \n Enter 1 or 2");
                    this.performTransactions();
                    break;
            }
            return Balance;
        }

        /*public void WriteCustomerDetails()
        {
            performTransactions();
            Console.WriteLine($"Name: {accountHolderName} \n Balance: {balance} \n Status: {status}" );
        }*/
        public string accHname() 
        {
            return accountHolderName;
        }
    }
}
