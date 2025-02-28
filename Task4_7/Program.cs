namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится n. Определить количество цифр в числе
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());

            int res = n;
            int i = 0;
            if (res == 0)
                Console.WriteLine("Количество цифр в числе = 1");
            else
            {
                while (res != 0)
                {
                    res = res / 10;
                    i++;
                }
                Console.WriteLine("Количество цифр в числе = {0}",i);
            }
            Console.ReadKey();
        }
    }
}
