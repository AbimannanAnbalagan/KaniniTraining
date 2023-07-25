using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class CustomException
    {
        public void CheckVal(int val)
        {
            if (val<0) {
                throw new ArgumentException("\nAge should not be less than Zero");
            }
            else if (val < 18)
            {
                throw new ArithmeticException("\nYour age must be 18\nThen only you're eligible for voting");
            }
            else
            {
                Console.WriteLine("You're Eligible For Voting");
            }
        }
    }
}
