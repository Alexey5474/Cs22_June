using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фактическое количество воды в меньшей емкости от 0 до 5:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите фактическое количество воды в большей емкости от 0 до 8:");
            int b = Convert.ToInt32(Console.ReadLine());
            int resa;
            int resb;
            int sum = a + b;
            Console.WriteLine($"sum={sum}");
            int ostatok = sum - 8;
            Console.WriteLine($"ostatok={ostatok}");
            if (sum > 8)
            { 
                    resb = 8;
                    resa = ostatok;
            }
            else
            {
                resb = sum;
                resa = 0;
            }
            Console.WriteLine($"Было в маленькой {a} из 5, в большой {b} из 8\nСтало: в маленькой {resa} из 5, в большой {resb} из 8");
            Console.ReadKey();


        }
    }
}
