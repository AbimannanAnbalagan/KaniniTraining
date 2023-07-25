using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    
    internal class Qstn2_b
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo($@"D:\\c#\\Employee.txt");
            using StreamWriter str = fi.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("Hr Tl Tl Hr");
            Console.WriteLine("Written");


        }
        public void Readfile()
        {
            string path = ($@"D:\\c#\\Employee.txt");
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            string text = System.IO.File.ReadAllText($@"D:\\c#\\Employee.txt");
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Hr")
                {
                    count1++;
                }
                else if (words[i] == "Tl")
                {
                    count2++;
                }
            }

            Console.WriteLine(" Count of Hr" + count1);
            Console.WriteLine(" Count of Tl" + count2);
            FileInfo fi = new FileInfo($@"D:\\c#\\HR.txt");
            using StreamWriter str = fi.CreateText();
            str.WriteLine("Count of Hr: " + count1);

            FileInfo fi1 = new FileInfo($@"D:\\c#\\TL.txt");
            using StreamWriter str1 = fi1.CreateText();
            str1.WriteLine("Count of Tl: " + count2);

            reader.Close();
            fileStream.Close();


        }

    }
}
