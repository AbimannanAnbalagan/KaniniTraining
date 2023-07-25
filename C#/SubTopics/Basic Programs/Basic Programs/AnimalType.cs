using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal interface AnimalType
    {
        public void Type(string Name)
        {
            if (Name == "dog")
            { Console.WriteLine("Omnivore"); }
            else if (Name == "cow")
            { Console.WriteLine("Herbivore"); }
        }
    }
}
