﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_01_task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c;
            c = "успех";
            b = "тоже провал";
            a = "провал";
            b = c;
            c = b;     
            a = b;
            b = a;
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
