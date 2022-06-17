using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_02_task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите величину угла:");
            Double y = Convert.ToDouble(Console.ReadLine());
            double result = 5 * Math.Cos(y * Math.PI / 180);
            Console.WriteLine("{0:F4}", result);
            Console.ReadKey();
        }
    }
}
