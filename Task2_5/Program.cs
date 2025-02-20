namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Вводится длина трубы в метрах. Округлить длину до целых в большую сторону. Например, 
                17,0  -> 17
                17,3  -> 18
                17,7  -> 18
             --------------------------------------------------------- */
            double input = Convert.ToDouble(Console.ReadLine());

            int result = Convert.ToInt32(Math.Ceiling(input));
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
