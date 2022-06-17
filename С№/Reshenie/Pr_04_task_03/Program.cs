using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(Math.Abs(a));
            }
            Console.ReadKey();
        }
    }
}
