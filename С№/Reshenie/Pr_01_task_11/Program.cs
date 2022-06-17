using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_01_task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину катета:");
            Double cathetus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите величину прилежащего угла:");
            Double angleDeg = Convert.ToDouble(Console.ReadLine());
            double angleRad = angleDeg * Math.PI / 180;
            double Cos = Math.Cos(angleRad);
            Double hypotenuse = cathetus / Cos;
            Console.WriteLine("Значение угла в радианах {0:F4}\nКосинус этого угла {1:F4}\nДлина гипотенузы {2:F4}", angleRad,Cos, hypotenuse);


            Console.ReadKey();
        }
    }
}
