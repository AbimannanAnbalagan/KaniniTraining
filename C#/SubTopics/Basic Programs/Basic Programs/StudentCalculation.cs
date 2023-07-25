using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
        internal class StudentCalculation : StudentMarks
        {
            private double tot, avg;
            public StudentCalculation(int rno, string name, double marks1, double marks2, double marks3, 
                double tot, double avg) : base(marks1,marks2,marks3,rno,name)
            
                
                {
                    this.Tot = tot;
                    this.Avg = avg;
                }
            

            public double Tot { get => tot; set => tot = value; }
            public double Avg { get => avg; set => avg = value; }


        public void Calculate()
        {
            this.Tot= this.Marks1 + this.Marks2+ this.Marks3;
            this.Avg = this.Tot/3;
        }

        }

    }

