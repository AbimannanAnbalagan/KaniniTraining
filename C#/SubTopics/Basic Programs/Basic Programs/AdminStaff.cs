using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class AdminStaff : College
    {
        private int adminid;
        private string namea;
        private double salary;

        public AdminStaff(string collegename, string address, int pin,int adminid , string name , double salary)
            : base(collegename,address,pin)
        {
            this.Adminid = adminid;
            this.NameA = namea;
            this.Salary = salary;
        }

        public int Adminid { get => adminid; set => adminid = value; }
        public string NameA { get => namea; set => namea = value; }
        public double Salary { get => salary; set => salary = value; }

        public double calculatesalary()
        {
            double da = 0.3, hra = 1.5;
            double allowances = salary + ((salary * da) + (salary * hra));
            double pf = 0.2;
            double deductions = salary * pf;
            double netsal = salary + allowances + deductions;
            return netsal;
        }
    }
}
