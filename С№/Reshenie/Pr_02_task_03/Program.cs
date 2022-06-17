using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_02_task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            Double a = Convert.ToDouble(Console.ReadLine());
            double result = a + 7;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
