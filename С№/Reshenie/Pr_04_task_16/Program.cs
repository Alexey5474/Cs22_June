using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_04_task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите букву из списка: a,b,c,d,e,f,g,h");
            string a = Console.ReadLine();
            string b = "a\nb\nc\nd\ne\nf\ng\nh";
            string c = " найдено";
            if (a == "a") Console.WriteLine(b.Insert(1, c));
            else if (a == "b") Console.WriteLine(b.Insert(3, c));
            else if (a == "c") Console.WriteLine(b.Insert(5, c));
            else if (a == "d") Console.WriteLine(b.Insert(7, c));
            else if (a == "e") Console.WriteLine(b.Insert(9, c));
            else if (a == "f") Console.WriteLine(b.Insert(11, c));
            else if (a == "g") Console.WriteLine(b.Insert(13, c));
            else if (a == "h") Console.WriteLine(b.Insert(15, c));
            else Console.WriteLine("Некорректно введена буква");
            Console.ReadKey();
        }
    }
}
