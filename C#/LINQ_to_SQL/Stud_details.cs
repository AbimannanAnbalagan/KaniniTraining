using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_SQL
{
    internal class Stud_details
    {
        StudentClassesDataContext stucontext = new StudentClassesDataContext();
        public void ReadData()
        {
            var result = from st in stucontext.stud_details
                         where st.rno == 23099
                         select st;

            foreach (var item in result)
            {
                Console.WriteLine(item.rno + "  " + item);
            }
           

            var result1 = stucontext.stud_details.Select(st => st.rno);
            var result2 = stucontext.stud_details.Where(st => st.rno == 19002);
        }

        public void Aggregate()
        {
            var count = (from st in stucontext.stud_details select st).Count() ;
            Console.WriteLine("count = "+count);
            int? min = (from st in stucontext.stud_details select st.rno).Min();
            int max = (Int32)(from st in stucontext.stud_details select st.rno).Max();
            var avg = (from st in stucontext.stud_details select st.rno).Average();
            var contains = (from st in stucontext.stud_details select st.name).Contains("Abi");

            var min1 = stucontext.stud_details.Min(st => st.rno);
            var avg1 = stucontext.stud_details.Average(st => st.rno);

        }

        public void joins()
        {
            var result = stucontext.student_details.Join(stucontext.student_marks,
                d => d.rno, m => m.rno, (d, m) => new
                {
                    rno = d.rno,

                    marks = m.marks
                }) ;

            foreach (var s in result)
            {
                Console.WriteLine(s.rno + "  " + s.marks);
            }
        }
    }
}
