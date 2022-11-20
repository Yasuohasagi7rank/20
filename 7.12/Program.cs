using System;

namespace _7._12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            b = Convert.ToInt32(Console.ReadLine());

            do
            {
                if ((a % 3 == 0) & (a % 10 == 2 | a % 10 == 4 | a % 10 == 8))
                {
                    b = b + a;
                }
                a++;
            }
            while (a < 100);
            Console.WriteLine(b);
        }
    }
}
