using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время Т:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 10;
            if(a>=0&&a<=59)
            {
                switch (b)
                {
                    case 3:
                        Console.WriteLine("Красный");
                        break;
                    case 4:
                        Console.WriteLine("Красный");
                        break;
                    case 8:
                        Console.WriteLine("Красный");
                        break;
                    case 9:
                        Console.WriteLine("Красный");
                        break;
                    default:
                        Console.WriteLine("Зеленый");
                        break;
                }
                
            }
            else Console.WriteLine("Значение T должно быть в интервале [0, 59]");
            Console.ReadKey();
        }
    }
}
