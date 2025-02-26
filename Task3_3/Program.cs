namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся четыре числа.Вывести большее их них.
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число d");
            int d = Convert.ToInt32(Console.ReadLine());

            switch (true)
            {
                case bool when a > b && a > c && a > d:
                    Console.WriteLine("max = {0}", a);
                    break;
                case bool when b > c && b > d:
                    Console.WriteLine("max = {0}", b);
                    break;
                case bool when c > a && c > d:
                    Console.WriteLine("max = {0}", c);
                    break;
                default:
                    Console.WriteLine("max = {0}", d);
                    break;
            }
            Console.ReadKey();
        }
    }
}
