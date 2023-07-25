using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    internal class FileOp
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo("D:\\c#");
            using StreamWriter str = fi.CreateText();
            Console.WriteLine("File has been created");
        }
    }
}




