using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class TeachingStaff : College
    {
        private int eid;
        private string name, dept , fvtsubject;
        private double salary;

        public TeachingStaff(string collegename, string address, int pin, int eid, string name,
            string dept, string fvtsubject, double salary)
            : base(collegename, address, pin)
        {
            this.eid = eid;
            this.name = name;
            this.Dept = dept;
            this.fvtsubject = fvtsubject;
            this.salary = salary;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public string Fvtsubject { get => fvtsubject; set => fvtsubject = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Dept { get => dept; set => dept = value; }

        public double calculatesalary()
        {
            double da = 0.4 , hra = 0.2;
            double allowances = salary +((salary * da) + (salary * hra));
            double pf = 0.25;
            double deductions = salary * pf;
            double netsal = salary + allowances + deductions;
            return netsal;
        }
    }
}
