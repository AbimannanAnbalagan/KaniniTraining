using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Read_File
    {
        public void process()
        {
            FileStream fileStream = new FileStream(@"D:\c#\Text files\new1.txt", FileMode.Open);
            StreamReader streamReader= new StreamReader(fileStream);
            string read = streamReader.ReadToEnd();
            Console.WriteLine(read);
        }
    }
}
