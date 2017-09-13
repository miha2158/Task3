using static System.Console;

namespace Task3
{
    class Program
    {
        public static bool test(double x, double y)
        {
            if (y >= 0)
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

            WriteLine();
            WriteLine(test(x, y)? "0": x.ToString());
            ReadKey(true);
        }
    }
}