using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndDelegates
{
    internal class GenUsage<T>
    {
        private T number;

        public GenUsage(T number)
        {
            this.Number = number;
        }

        public T Number { get => number; set => number = value; }
    }

    internal class GenUsageArr<T>
    {
        private T[] array;

        public GenUsageArr(int size)
        {
            array = new T[size];
        }

        public T getarr(int index)
        {
            return array[index];
        }

        public void setarr(int index, T value)
        {
            array[index] = value;
            //return value;

        }
   
    }
    internal class GUConstraints<T> where T : Exception
    {
        private T exec;

        public GUConstraints(T exec)
        {
            this.Exec = exec;
        }

        public T Exec { get => exec; set => exec = value; }

        public T disp()
        {
            return Exec;
        }
    }
}
