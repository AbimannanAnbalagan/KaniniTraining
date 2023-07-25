using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Interest : BankDetails
    {
        private double intprcent;
        
        public Interest(int intpercent, int accno, string accname, double balance, double intamt) :base(accno,  accname, balance, intamt)
        {
            this.Intprcent = intpercent;
        }

        public double Intprcent { get => intprcent; set => intprcent = value; }
        public override double CalculateInterest()
        {
            return Balance*(Intprcent/100);
        }
    }
}
