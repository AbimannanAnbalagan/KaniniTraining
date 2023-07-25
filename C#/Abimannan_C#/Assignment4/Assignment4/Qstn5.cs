using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Qstn5
    {
        public bool process(string colors)
        {
            int Red = 0;
            int Green = 0;
            int Blue = 0;
            int yellow = 0;
            
            for (int i =0 ; i < colors.Length; i++)
            {
                switch(colors[i])
                {
                    case 'R':
                        {
                            Red++;
                            break;
                        }
                    case 'G':
                        { 
                            Green++; 
                            break;
                        }
                    case 'B':
                        {
                            Blue++;
                            break;
                        }
                    case 'Y':
                        {
                            yellow++;
                            break;
                        }
                }
                if (Math.Abs(Red - Green) > 1 || Math.Abs(yellow - Blue) > 1)
                {
                    return false;
                }
            }
            bool result = (Red == Green) && (yellow == Blue);
            return result;

        }
    }
}
