using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_02_task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            Double x = Convert.ToDouble(Console.ReadLine());
            Double result = Math.Sin(x * Math.PI / 180);
            Console.WriteLine("{0:F4}", result);
            Console.ReadKey();
        }
    }
}
