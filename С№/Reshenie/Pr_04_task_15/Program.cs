using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());
            int a1;
            int b1;
            int c1;
            if (a >= 0)
            {
                a1 = a * a;
            }
            else a1 = a;
            if (b >= 0)
            {
                b1 = b * b;
            }
            else b1 = b;
            if (c >= 0)
            {
                c1 = c * c;
            }
            else c1 = c;
            Console.WriteLine($"{a1};{b1};{c1}");
            Console.ReadKey();
        }
    }
}
