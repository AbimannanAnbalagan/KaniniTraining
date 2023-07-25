using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class Qstn3_2 : Qstn3_1
    {
        double balance;
        public Qstn3_2(double balance)
        {
            this.Balance = balance;
        }

        public double Balance { get => balance; set => balance = value; }

        public void CallLog(List<long> list)
        {
            int count = 10;

            Console.WriteLine(list.Last());
            int check = 0;
            int count1 = count;

            while (check < count)
            {
                Console.WriteLine(list[count1 - 1]);
                check++;
                count1--;
            }
            
        }

        public void DialLastCall(List<long> list)
        { 
                if (Balance <= 0)
                {
                    try
                    {
                        Console.WriteLine("Not enough Balance");
                    }
                    catch (NotFiniteNumberException ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                }
                else
                {
                    Console.WriteLine("dialing...\n" + list.Last());
                    Console.WriteLine("Call Duartion is 4mins 10sec");
                }
        }
    }
}

