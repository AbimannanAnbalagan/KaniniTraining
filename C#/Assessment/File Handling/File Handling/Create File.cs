using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Create_File
    {
        public void process()
        {
            FileStream fileStream = new FileStream(@"D:\c#\Text files\new1.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("This is a sample document");
            streamWriter.WriteLine("The first file created");
            Console.WriteLine("Text File created");
            streamWriter.Close();
            fileStream.Close();
        }
    }
}
