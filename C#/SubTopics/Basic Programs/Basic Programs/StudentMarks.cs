using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentMarks : StudentDetails
    {
        private double marks1, marks2, marks3;


        public StudentMarks( double marks1, double marks2, double marks3 , int rno , string name) : base(rno , name)
        {
            this.Marks1 = marks1;
            this.Marks2 = marks2;
            this.Marks3 = marks3;
        }


        public double Marks1 { get => marks1; set => marks1 = value; }
        public double Marks2 { get => marks2; set => marks2 = value; }
        public double Marks3 { get => marks3; set => marks3 = value; }

    }
}
