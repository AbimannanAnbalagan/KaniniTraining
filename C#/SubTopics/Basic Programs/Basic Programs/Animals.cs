using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Animals : Sound, AnimalType
    {
        private string name;
        private int eyes,mouth,legs,tail;

        public Animals(string name, int eyes, int mouth , int legs , int tail)
        {
            this.Name = name;
            this.Eyes = eyes;
            this.Mouth = mouth;
            this.Legs = legs;
            this.Tail = tail;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Legs { get => legs; set => legs = value; }
        public int Tail { get => tail; set => tail = value; }
        public string Name { get => name; set => name = value; }

        public void MakeSound(string Name )
        {
            if (this.Name == "dog")
                Console.WriteLine("bow bow");
            else if (this.Name == "cat")
                Console.WriteLine("meow");
        }

        public void Type(string);
    }
}
