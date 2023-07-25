using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    partial class PartialDemo
    {
        int ans;

        public PartialDemo(int n1,int n2,int ans)
        {
            N1= n1;
            N2= n2;
            this.Ans = ans;
        }
        public int Ans { get => ans; set => ans = value; }

        public partial int calc();
        
    }
}
