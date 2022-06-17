using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите основание треугольника:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту треугольника:");
            int y= Convert.ToInt32(Console.ReadLine());
            if(x<=0)
            {
                Console.WriteLine("Длина основания треугольника должна быть положительна");
                return;
            }
            if (y <= 0)
            {
                Console.WriteLine("Высота треугольника должна быть положительна");
                return;
            }
            int result = (x * y)/2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
