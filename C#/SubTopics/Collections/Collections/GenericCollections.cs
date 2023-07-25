using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericCollections
    {
        public void List ()
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine($"First Element: {list[0]}");
            Console.WriteLine($"Count: {list.Count}");
            list.Append(6);
            list.Add(7);



            foreach (int i in list)
            {
                 Console.WriteLine(i);
            }

            list.Remove(0);
            Console.WriteLine("After Remove\nFirst Element"+list[0]);

            List<int> list2 = new List<int>();
            list2.Add(11);
            list2.Add(10);
            list2.Add(9);
            list2.Sort();
            Console.WriteLine("List2");
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Average "+list.Average());

            int f = 5;
            Console.WriteLine("Index"+list.FindIndex(a => a==f));

            list.Clear();
            Console.WriteLine("Before loop");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After loop");

        }

        public void StackElements()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(65);
            stack.Push(64);
            Console.WriteLine(stack.Contains(10));
            Console.WriteLine("Maximum Integer"+stack.Max());
            Console.WriteLine("Peek "+stack.Peek());

            Console.WriteLine("Befor Pop");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Popped element "+ stack.Pop());

            Console.WriteLine("After Pop");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            stack.Reverse();

            Console.WriteLine("After Reverse");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            
        }

        public void QueueElements()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("ONE");
            queue.Enqueue("TWO");
            queue.Enqueue("THREE");

            foreach (string i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n"+queue.First());

            queue.Dequeue();
            Console.WriteLine("\nAfter dequeue");
            foreach (string i in queue)
            {
                Console.WriteLine(i);
            }
        }

        public void HashElements()
        {
            Dictionary<string,string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("One", "Hey");
            keyValuePairs.Add("Two", "Hi");
            foreach(string i in keyValuePairs.Keys)
            {
                Console.WriteLine("key:"+i);
            }
            foreach (string i in keyValuePairs.Values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Accessong by key "+keyValuePairs["Two"]);
            
            Console.WriteLine(keyValuePairs.First());

            Dictionary<int,int> keyValuePairs1= new Dictionary<int,int>();
            keyValuePairs1.Add(1, 1);
            keyValuePairs1.Add(2, 2);
            Console.WriteLine(keyValuePairs1.Keys);
            Console.WriteLine(keyValuePairs1.Values);
            Console.WriteLine(keyValuePairs1.First());
        }

        public void SortedListElements()
        {
            SortedList<int,int> keyValuePairs= new SortedList<int,int>();
            keyValuePairs.Add(1, 1);
            keyValuePairs.Add(3, 4);
            keyValuePairs.Add(2, 3);
            Console.WriteLine(keyValuePairs.First());

            foreach (int i in keyValuePairs.Keys)
            {
                Console.WriteLine(i);
            }
        }
    }
}
