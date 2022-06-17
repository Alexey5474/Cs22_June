using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите делимое:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите делитель:");
            int b = Convert.ToInt32(Console.ReadLine());
            int res1 = a / b;
            int res2 = a % b;
            Console.WriteLine($"Делимое {a}, делитель {b}, частное {res1}, остаток {res2}");
            Console.ReadKey();

        }
    }
}
