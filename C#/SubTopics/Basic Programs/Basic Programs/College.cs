﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class College
    {
        private string collegename, address;
        private int pin;

        public College (string collegename, string address, int pin)
        {
            this.Collegename = collegename;
            this.Address = address;
            this.Pin = pin;
        }

        
        public int Pin { get => pin; set => pin = value; }
        public string Address { get => address; set => address = value; }
        public string Collegename { get => collegename; set => collegename = value; }
    }
}
