namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n
            double res = 0;
            double i = 2;
            double n = 2;
            double input=0;

            while (input < 1)
            {
                Console.WriteLine("Введите число больше 0");
                input = Convert.ToDouble(Console.ReadLine());
            }

            if (n == 1)
                Console.WriteLine("Ответ = {0}", n + 1);
            else
            {
                while (i <= n)
                {
                    res = res + 1 / i++;
                }
                Console.WriteLine("Ответ = {0}", res + 1);
            }
            Console.ReadKey();
        }
    }
}
