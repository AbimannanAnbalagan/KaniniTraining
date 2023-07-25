using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Qstn3
    {
        string input1;

        public string Input1 { get => input1; set => input1 = value; }

        public string SubstringCount(string input1)
        {
            this.Input1 = input1;
            string result = "";
            char check = new char();
            int count = 1;
            for (int i = 0; i < Input1.Length; i++)
            {
                if (i == 0) { check = input1[i]; }

                else if (check == Input1[i])
                {
                    count++;
                }
                else
                {
                    result += Input1[i - 1];
                    if (count > 1)
                    {
                        result += count;
                        count = 1;
                    }
                    check = Input1[i];
                }
                if (i == Input1.Length - 1)
                {
                    result += input1[i];
                    if (count > 1)
                    {
                        result += count;
                    }
                }
            }
            return result;
        }
    }
}

