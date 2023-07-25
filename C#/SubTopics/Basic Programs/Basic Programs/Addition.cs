using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Addition
    {
        /*
        private int num1, num2,ans;

        public Addition(int num1 , int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Ans { get => ans; set => ans = value; }

       internal int add(ref int num1 , ref int num2)
        {
            num1 = num1+ num2;
            return num1;
        }*/
        internal void add(out int num1, out int num2)
        {
            num1=7+5;
            num2=8+6;
        }
    }
}
