using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    internal class EnumDemo
    {
        enum colors
        {
            Red,Green,Yellow,Blue
        } 

        public void Display()
        {
            colors color1 = colors.Red;
            Console.WriteLine(color1);
            Console.WriteLine(colors.Red);
            Console.WriteLine();
        }
    }
}
