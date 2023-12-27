using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap1
{
    class Program
    {
        static bool IsFermatTheoremTrue(int a, int b, int c, int n)
        {
            if (n <= 2 || a <= 0 || b <= 0 || c <= 0)
            {
                return false; // Проверка некорректных значений параметров
            }

            // Проверка условия теоремы
            double left = Math.Pow(a, n) + Math.Pow(b, n);
            double right = Math.Pow(c, n);

            return left == right;
        }

        static void Main()
        {
            // Проверка для некоторых случаев
            Console.WriteLine($"n=3, a=3, b=4, c=5: {IsFermatTheoremTrue(3, 4, 5, 3)}"); // true
            Console.WriteLine($"n=4, a=4, b=3, c=5: {IsFermatTheoremTrue(4, 3, 5, 4)}"); // false

            // Проверка для случайных значений n, a, b, c
            Random random = new Random();
            int n = random.Next(3, 10); // Случайное значение n от 3 до 10
            int a = random.Next(1, 100); // Случайное значение a от 1 до 100
            int b = random.Next(1, 100); // Случайное значение b от 1 до 100
            int c = random.Next(1, 100); // Случайное значение c от 1 до 100
            Console.WriteLine($"n={n}, a={a}, b={b}, c={c}: {IsFermatTheoremTrue(a, b, c, n)}");

            Console.ReadLine();
        }
    }
}
