using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину куба:");
            int x = Convert.ToInt32(Console.ReadLine());
          
            if(x<=0)
            {
                Console.WriteLine("Длина ребра должна быть положительной");
                return;
            }
            int result = 6 * x * x;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
