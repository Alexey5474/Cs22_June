using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            double a = 61 - x;
            if (a < 0)
            {
                Console.WriteLine("Подкоренное выражение не может быть отрицательным");
                return;
            }
            double res = 3*Math.Sqrt(a);
            Console.WriteLine(res);
        }
    }
}
