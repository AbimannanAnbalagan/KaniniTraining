using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class Qstn1
    {
        int rows = 0;

        public Qstn1(int rows)
        {
            this.Rows = rows;
        }

        public int Rows { get => rows; set => rows = value; }

        public void CharacterPattern()
        {
            for (int i=1; i<=rows; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void NumericPattern()
        {
            for (int i= 0; i < rows; i++)
            {
                for (int j=1; j < rows - i ; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k-2<i; k++)
                {
                    Console.Write("  "+k+"  ");
                }
                Console.WriteLine();
            }
        }
    }
}
