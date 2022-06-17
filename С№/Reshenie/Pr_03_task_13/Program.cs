using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_03_task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину рулона:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите расход материала:");
            int b = Convert.ToInt32(Console.ReadLine());
            int res1 = (a * 100) / b;
            int res2 = (a * 100) % b;
            Console.WriteLine($"Длина рулона в сантиметрах равна {a}\nИз этого материала получится {res1} изделий и останется {res2} см");
            Console.ReadKey();
        }
    }
}
