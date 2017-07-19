using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Task3
{
    class Program
    {
        public static bool test(double x, double y)
        {
            if (y > 0)
                if (x * x + y * y <= 4)
                    if (x * x + y * y >= 1)
                        return true;

            return false;
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

            string yes = "Принадлежит";
            string no = "Не принадлежит";

            /*if(test(x,y))
                WriteLine(yes);
            else WriteLine(no);*/
            WriteLine(test(x, y)? yes: no);

            ReadKey(true);
        }
    }
}
