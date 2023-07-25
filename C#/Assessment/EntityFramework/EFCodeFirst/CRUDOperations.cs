using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    internal class CRUDOperations
    {
        public void InsertRecordsInCourseEntity()
        {
            using (var context = new CollegeContext())
            {
                var stud = new Course()
                {
                    CourseId = 1002,
                    CourseName = "CSC"
                };
                context.Courses.Add(stud);
                context.SaveChanges();

            }
        }
        public void UpdateRecordsInCourseEntity() 
        {
            using (var context = new CollegeContext())
            {
                var st = context.Students.First<Student>();
                st.Age = 23;
                context.Remove(st);
                context.SaveChanges();

            }
        }

        public void DeleteRecordsInCourseEntity()
        {
            using (var context = new CollegeContext())
            {
                var st= context.Students.First<Student>();
                context.Students.Remove(st);
                context.SaveChanges();
            }
        }
    }
}
