using System.Security.Cryptography;

namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Два треугольника заданы длинами своих сторон. Определите, площадь какого из них больше (создайте метод Square для вычисления площади треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона.

            //S= sqrt(p⋅(p−a)⋅(p−b)⋅(p−c)) - площадь
            //p= (a + b + c)/2  — полупериметр треугольника.

            Console.WriteLine("Введите сторону a1 треугольника 1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b1 треугольника 1");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону c1 треугольника 1");
            double c1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите сторону a2 треугольника 2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b2 треугольника 2");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону c2 треугольника 2");
            double c2 = Convert.ToDouble(Console.ReadLine());

            //double a1 = 5;
            //double b1 = 6;
            //double c1 = 3.1;

            //double a2 = 1;
            //double b2 = 2;
            //double c2 = 3;

            double s1 = Square(a1, b1, c1);
            double s2 = Square(a2, b2, c2);

            Console.WriteLine(s1 > s2 ? "Площадь s1 больше площади s2" : s1 == s2 ? "Площади s1 и s2 равны" : "Площадь s2 больше площади s1");

            Console.ReadKey();
        }
        static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
