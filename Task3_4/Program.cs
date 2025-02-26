namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три разных числа. Вывести медиану – среднее по величине число.

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
