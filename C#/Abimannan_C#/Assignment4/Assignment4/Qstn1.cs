using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment4
{
    /*
    internal class Qstn1
    {
        int count;
        string input;

        public Qstn1(int count, string input)
        {
            this.Count = count;
            this.Input = input;
        }

        public int Count { get => count; set => count = value; }
        public string Input { get => input; set => input = value; }

        public void qstn1_a()
        {
            string[] arr = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                Console.Write($"Enter the string{i + 1}: ");
                arr[i] = Console.ReadLine();
            }

            foreach (string i in arr)
            {
                if (i.Contains(Input))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void qstn1_b()
        {
            string[] arr = new string[Count];
            for (int i=0; i<Count;i++)
            {
                Console.Write($"Enter the string{i+1}: ");
                arr[i] = Console.ReadLine();
            }

            foreach(string i in arr)
            {
                if (i.Contains(Input))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }*/

    internal class Qstn1
    {
        public Qstn1()
        {
            
        }


        public void a(string[] arr)
        {
            FileStream fileStream = new FileStream(@"D:\c#\Text files\qstn1.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fileStream);

            foreach (string str in arr)
            {
                if (!str.Contains("fox"))
                {
                    sw.WriteLine(str);
                }
            }
            Console.WriteLine("Created the file");
            
            sw.Close();
            fileStream.Close();
        }

        public void b(string[] arr)
        {
            FileStream fileStream = new FileStream(@"D:\c#\Text files\qstn1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fileStream);
            string line = sr.ReadLine();

            while (line != null)
            {
                if (!line.Contains("fox"))
                {
                    Console.WriteLine(line);
                }
            }

            sr.Close();
            fileStream.Close();
        }
    }



}
