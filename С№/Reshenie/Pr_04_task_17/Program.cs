using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите букву из списка: a,b,c,d,e,f,g,h");
            string a = Console.ReadLine();
            if (a == "a") Console.WriteLine("a");
            else if (a == "b") Console.WriteLine("ab");
            else if (a == "c") Console.WriteLine("abc");
            else if (a == "d") Console.WriteLine("abcd");
            else if (a == "e") Console.WriteLine("abcde");
            else if (a == "f") Console.WriteLine("abcdef");
            else if (a == "g") Console.WriteLine("abcdefg");
            else if (a == "h") Console.WriteLine("abcdefgh");
            else Console.WriteLine("abcdefgh");
            Console.ReadKey();
        }
    }
}
