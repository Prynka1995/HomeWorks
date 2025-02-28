namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти n! Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.

            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int inc = i;
            //int inc = 0;
            for (; i < n;)
            {
                inc = inc*++i;
            }
            Console.WriteLine("Факториал числа !n = {0}", inc);
            Console.ReadKey();
        }
    }
}
