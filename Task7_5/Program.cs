using System.Security.Cryptography;

namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Напишите перегруженные методы Multiply, которые могут умножать два числа (целые или дробные) и возвращать результат.
            // Пример вызова:
            //Console.WriteLine(Multiply(2, 3)); // Вывод: 6
            //Console.WriteLine(Multiply(2.5, 3.5)); // Вывод: 8.75

            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2.5, 3.5));
            Console.ReadKey();
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
