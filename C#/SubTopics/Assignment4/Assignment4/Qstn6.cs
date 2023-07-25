using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Qstn6
    {
        int num;
        int times;
        int total;
        int value=11;
        public Qstn6(int num , int times) 
        {
            this.Num = num;
            this.Times = times;
            
        }

        public int Num { get => num; set => num = value; }
        public int Times { get => times; set => times = value; }
        public int Value { get => value; set => this.value = value; }

        public void process()
        {
            total = num;
            for (int i = 0;i< times-1; i++)
            {
                total = Convert.ToInt32(num.ToString()+total.ToString()); 
            }

            int num1 = total;

            while(value>=10)
            {
                value = 0;
                while (num1 > 0 )
                {
                    Value += num1 % 10;
                    num1 = num1 / 10;   
                }   
                num1 = value;
            }
        }
    }
}

