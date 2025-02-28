namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]
            int input = 0;

            while (input < 20 || input >60)
            {
                Console.WriteLine("Введите число из диапазона [20; 60]");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Done");
            }

            Console.ReadKey();
        }
    }
}
