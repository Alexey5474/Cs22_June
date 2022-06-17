using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b= Convert.ToInt32(Console.ReadLine());
            if (a % b != 0) 
            {
                Console.WriteLine($"{a} не делится нацело на {b}");
            }
            else
            {
                Console.WriteLine(a / b);
            }
            Console.ReadKey();
        }
    }
}
