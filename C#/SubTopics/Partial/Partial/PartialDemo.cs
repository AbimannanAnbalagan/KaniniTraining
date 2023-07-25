using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    partial class PartialDemo
    {
        int n1, n2;

        public PartialDemo()
        {
            N1=10; 
            N2=10;
        }

        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }

        public partial int calc()
        {
            Console.WriteLine("partial Demo 1");
            return n1 + n2;
        }

        public void calc1()
        {
            Console.WriteLine("public");
        }
    }
}

