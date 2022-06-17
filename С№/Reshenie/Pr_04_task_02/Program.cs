using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>=0)
            {
                Console.WriteLine($"Корень из {a:F4} равен {Math.Sqrt(a):F4}");
            }
            else
            {
                Console.WriteLine($"Квадрат из {a:F4} равен {(a*a):F4}");
            }
            Console.ReadKey();
        }
    }
}
