using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal abstract class BankDetails
    {
        private int accno;
        private string accname;
        private double balance;
        private double intamt;

        public BankDetails(int accno, string accname, double balance, double intamt)
        {
            this.accno = accno;
            this.accname = accname;
            this.balance = balance;
            this.intamt = intamt;
        }

        public int Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Intamt { get => intamt; set => intamt = value; }

        public abstract double CalculateInterest();

    }
}
