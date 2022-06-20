using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_05_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число x:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (a <= b)
            {
                if (x > a && x < b)
                {
                    Console.WriteLine($"{x} попадает в интервал от {a} до {b}");
                }
                else Console.WriteLine($"{x} за пределами интервала от {a} до {b}");
            }
            else Console.WriteLine("Некорректный интервал. Левая граница должна быть меньше правой.");
            Console.ReadKey();
        }
    }
}
