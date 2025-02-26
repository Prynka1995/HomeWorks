namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три числа.Вывести большее их них.
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());

            switch (true)
            {
                case bool when a > b && a > c:
                    Console.WriteLine("max = {0}", a);
                    break;
                case bool when b > c:
                    Console.WriteLine("max = {0}", b);
                    break;
                default:
                    Console.WriteLine("max = {0}", c);
                    break;
            }
            Console.ReadKey();
        }
    }
}
