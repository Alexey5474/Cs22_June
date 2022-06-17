using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Максимальное {Math.Max(a, b)}, минимальное {Math.Min(a, b)}. Разница {Math.Max(a,b)-Math.Min(a, b)}");
            Console.ReadKey();
        }
    }
}
