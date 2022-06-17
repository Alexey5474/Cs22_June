using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("x не может быть отрицательным");
                return;
            }
            double res = Math.Sqrt(x);
            Console.WriteLine(res);

        }
    }
}
