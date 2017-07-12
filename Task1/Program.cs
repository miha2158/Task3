using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Task1
{
    class Program
    {
        public static void test(double x, double y)
        {
            string yes = "Принадлежит";
            string no = "Не принадлежит";

            if (y < 0)
            {
                WriteLine(no);
                return;
            }

            if (x * x + y * y < 1)
            {
                WriteLine(no);
                return;
            }

            if (x * x + y * y <= 4)
            {
                WriteLine(yes);
                return;
            }
        }

        static void Main(string[] args)
        {
            WriteLine("Введите координату 'X'");
            double x = 0;
            while (!double.TryParse(ReadLine().Replace(".",","),out x))
                WriteLine("Введите число");

            WriteLine("Введите координату 'Y'");
            double y = 0;
            while (!double.TryParse(ReadLine().Replace(".", ","), out y))
                WriteLine("Введите число");

            test(x,y);
            
            ReadKey(true);
        }
    }
}
