﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BackwardChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            GDB db = new GDB(ConfigurationManager.AppSettings["InputFileName"]);
        }
    }
}
