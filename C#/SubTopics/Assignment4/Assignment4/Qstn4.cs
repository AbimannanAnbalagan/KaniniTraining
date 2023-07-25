using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Qstn4
    {
        private string string1;
        private string string2;
        private string preffix = "";
        private string content1 = "";
        private string content2 = "";

        public Qstn4(string string1 , string string2)
        {
            this.String1 = string1;
            this.String2 = string2;
        }

        public string String1 { get => string1; set => string1 = value; }
        public string String2 { get => string2; set => string2 = value; }
        public string Preffix { get => preffix; set => preffix = value; }
        public string Content1 { get => content1; set => content1 = value; }
        public string Content2 { get => content2; set => content2 = value; }

        public void process()
        {
            

            for (int i=0;i<string2.Length;i++)
            {
                if (string2[i] == string1[i])
                {
                    Preffix += string1[i];
                }
                else { break; }
            }
            
            Content1 =  String1.Substring(Preffix.Length);
            Content2 = String2.Substring(Preffix.Length);
            
        }
    }
}
