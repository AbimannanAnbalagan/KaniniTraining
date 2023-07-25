using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BankAccount
    {
        private int cust_id;
        private long accno;
        private string name;
        private double balance;
        private string status;

        public BankAccount(int custid, long accno, string name, double balance, string status)
        {
            this.Cust_id = custid;
            this.Accno = accno;
            this.Name = name;
            this.Balance = balance;
            this.Status = status;
        }

        public int Cust_id { get => cust_id; set => cust_id = value; }
        public long Accno { get => accno; set => accno = value; }
        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }

        public void checkaccstatus(long accno)
        {
            if (accno == Accno)
            {
                name = Name;
                cust_id = Cust_id;
                balance = Balance;
                status = Status;

                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        public void checkaccstatus(int cust_id)
        {
            if (cust_id == this.Cust_id)
            {
                name = Name;
                accno = Accno;
                balance = Balance;
                status = Status;
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
