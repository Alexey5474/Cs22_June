using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Первое число больше");
            }
            else if (a < b)
            {
                Console.WriteLine("Второе число больше");
            }
            else Console.WriteLine("Числа равны");
            Console.ReadKey();
        }
    }
}
