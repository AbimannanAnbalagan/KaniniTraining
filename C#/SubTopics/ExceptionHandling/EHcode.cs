using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class EHcode
    {
        int n1, n2, ans=0;

        public EHcode(int n1 , int n2 ,int ans)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.ans = ans;
        }

        public void add()
        {
            this.ans=this.n1+this.n2;
            Console.WriteLine(this.n1+" "+this.n2);
        }
        public void mul()
        {
            this.ans = this.n1 * this.n2;
            Console.WriteLine(this.ans);
        }
        public void div()
        {
            try
            {
                this.ans = this.n1 / this.n2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Dont give zero for n2");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.WriteLine(this.ans);
        }

        public void arr()
        {
            int[] arr = {1,3};
            try
            {
                Console.WriteLine(arr[2]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CheckVal(int val)
        {
            if (val < 0)
            {
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
