using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_02_task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x:");
            Double Xa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y:");
            Double Ya = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину линии:");
            Double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите дирекционный угол:");
            Double angleDeg = Convert.ToDouble(Console.ReadLine());
            Double Dx = distance * Math.Cos(angleDeg * Math.PI / 180);
            Double Dy= distance * Math.Sin(angleDeg * Math.PI / 180);
            Double Xb = Xa + Dx;
            Double Yb = Ya + Dy;
            Console.WriteLine("Приращение координат: \u0394x = {0:F4}; \u0394y = {1:F4}\nКоординаты второй точки({2:F4}; {3:F4})", Dx,Dy,Xb,Yb);
            Console.ReadKey();


        }
    }
}
