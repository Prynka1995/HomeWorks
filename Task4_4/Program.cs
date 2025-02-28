namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся целые числа a>0, b<0. Найти a^b. Не использовать класс Math


            int a = 0; //число
            int b = 0; //степень
            int i = 1; //счетчик

            while (a < 1 || b > 1)
            {
                Console.WriteLine("Введите число a больше 0");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите степень b числа a больше 0");
                b = Convert.ToInt32(Console.ReadLine());

            }
            int res = a;
            if (b == 1 || a == 1)
                Console.WriteLine("Ответ = 1/{0}", a);
            else
            {
                while (i < -b)
                {
                    res = res * a;
                    ++i;
                }
                Console.WriteLine("Ответ = 1/{0}", res);
            }
            Console.ReadKey();
        }   
    }
}
