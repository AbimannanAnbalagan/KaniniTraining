using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stud_details stud_Detail = new Stud_details();
            //stud_Detail.Aggregate();
            stud_Detail.joins();
            Console.Read();
        }
    }
}
