using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class StaticDem
    {
        static int cno = 1234, prer = 1110, curr = 1230;
        static double amount;
        
        public static int Cno { get => cno; set => cno = value; }
        public static int Prer { get => prer; set => prer = value; }
        public static int Curr { get => curr; set => curr = value; }
        public static double Amount { get => amount; set => amount = value; }

        static StaticDem()
        {
            Amount = 0;
        }

        public static double calculate()
        {
            Amount = (Curr - Prer) * 12;
            return Amount;
        }
    }
}
