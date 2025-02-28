namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить, является ли оно степенью 2 - ки ?
            //n = 2^k.

            int n = 4;
            while (n < 5)
            {
                Console.WriteLine("Введите число больше 0");
                n = Convert.ToInt32(Console.ReadLine());
            }
            if (n == 1 || n == 2)
            {
                Console.WriteLine("n является степенью 2ки");
            }
            else if (n == 4)
            {
                Console.WriteLine("n НЕ является степенью 2ки");
            }
            else
            {
                while (true)
                {
                    if (n / 2 == 2)
                    {
                        Console.WriteLine("n является степенью 2ки");
                        break;
                    }
                    else if (n % 2 != 0)
                    {
                        Console.WriteLine("n НЕ является степенью 2ки");
                        break;
                    }
                    n = n / 2;
                }
            }
            Console.ReadKey();
        }
    }
}
