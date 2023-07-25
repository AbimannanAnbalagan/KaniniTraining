using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Qstn2
    {
        public string StringCount(string input)
        {
            string s = "";
            for (int i =0; i < input.Length; i++)
            {
                if (i==0) s = s + input[i];
                else
                {
                    int m = 0;
                    for (int j =0;j<i;j++)
                    {                       
                        if ( input[j] == input[i])
                        {
                            m++;
                            break;
                        }
                    }
                    if (m == 0) s = s + input[i];
                }
            }
            return s;
        }
    }
}
