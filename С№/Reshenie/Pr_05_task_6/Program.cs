using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_05_task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру tC:");
            double a = Convert.ToInt32(Console.ReadLine());
            double c = 4.2 * Math.Pow(10,3);
            double r= 2.26*Math.Pow(10, 6);
            double λ = 3.3 * Math.Pow(10, 5);
            double tK = a + 273.15;
            double energy1;
            double energy2;
            if(a<0&&a>-273)
            {
                energy1 = 17 * tK * c;
                Console.WriteLine($"Агрегатное состояние:кристалл\nВнутренняя энергия:{energy1:F2} Дж");
            }
            else if(a==0)
            {
                energy1 = 17 * tK * c;
                energy2 = 17 * (tK * c + r);
                Console.WriteLine($"Вещество в переходном состоянии.\nАгрегатное состояние: кристалл\nВнутренняя энергия: {energy1:F2} Дж\nАгрегатное состояние: жидкость\nВнутренняя энергия: {energy2:F2} Дж");
            }
            else if (a > 0 && a < 100)
            {
                energy2 = 17 * (tK * c + r);
                Console.WriteLine($"Агрегатное состояние: жидкость\nВнутренняя энергия: {energy2:F2} Дж");

            }
            else if (a == 100)
            {
                energy1= 17 * (tK * c + r);
                energy2 = 17 * (tK * c + r + λ);
                Console.WriteLine($"Вещество в переходном состоянии.\nАгрегатное состояние: жидкость\nВнутренняя энергия: {energy1:F2} Дж\nАгрегатное состояние: газ\nВнутренняя энергия: {energy2:F2} Дж");

            }
            else if(a>100)
            {
                energy2 = 17 * (tK * c + r + λ);
                Console.WriteLine($"Агрегатное состояние: газ\nВнутренняя энергия: {energy2:F2} Дж");
            }
            else Console.WriteLine("Некорректная температура");
            Console.ReadKey();
        }
            

        }
    }

