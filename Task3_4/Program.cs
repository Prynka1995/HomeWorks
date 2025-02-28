namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три разных числа. Вывести медиану – среднее по величине число.
/*
 * (a + b + c) / 3 - это среднее арифметическое.
По условию нужна была медиана - это число, которое в упорядоченном ряду находится "посередине". Например, для чисел 3, 10, 1 медианой будет 3. Т.е. идея была в том, чтобы найти максимальное и минимальное числа, а вывести то, которое останется
*/

            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Введите число b, отличное от a");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c отличное от a и b");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a != b && b != c && c != a)
            {
                Console.Write("Среднее число = ");
                Console.WriteLine((a + b + c) / 3);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Введите разные числа");
            }
        }
    }
}
