using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    partial class Qstn2_a1
    {
        private int num1;
        private int num2;
        private int result;

        public Qstn2_a1(int num1 , int num2) 
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Result { get => result; set => result = value; }

        public void add()
        {
            Result = Num1 + Num2;

        }
    }
}
