using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_01_Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string b= Console.ReadLine();
            /*Console.WriteLine("Меня зовут " + b + ","+" " + a + " " + b);*/
            Console.WriteLine("Меня зовут {0}, {1} {0}", b, a);
            Console.ReadKey();

        }
    }
}
