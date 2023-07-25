using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class JArray
    {
        public void jaggedarrayElements()
        {
            int[][] jgarr = new int[5][];
            jgarr[0] = new int[3];
            jgarr[1] = new int[6];
            jgarr[2] = new int[5];
            jgarr[3] = new int[4];
            jgarr[4] = new int[3];
            jgarr[0] = new int[] {3,4,5,6,7,9,77 };

            Console.WriteLine("Accessed by Index: "+jgarr[0][3]);

            foreach (int i in jgarr[0]) 
            {
                Console.WriteLine(i);
            }

        }
        public void ThreeDimensional()
        {
            int[][,] Td = new int[2][,]
            {
                new int[,]
                {
                    {1,2 ,3},
                    {3,3,4} 
                },
                new int[,]{
                    {1341,245,137,664},
                    {124,265,312,413},
                    {4,31,314,314}
                }
            };

            Console.WriteLine(Td[0][1,2]);
        }

    }
}
