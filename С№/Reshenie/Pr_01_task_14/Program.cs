using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_01_task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадратное уравнение {0}*x*x + {1}*x + {2} = 0.\nЕго дискриминант вычисляется по формуле: d = {1}*2 - 4*{0}*{2}", a, b, c);
            Console.ReadKey();
        }
    }
}
