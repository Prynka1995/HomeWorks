namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Застройщик построил n домов. Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом», например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».

            /* 0 домов
             * 1,21, 31. 41 дом
             * 0, 5-20, 25-30, 35-40 домов,
             * 2,3,4, 22, 23, 24, 32, 33, 34 дома

             * 
             */
            Console.WriteLine("Сколько мы построили домов? Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (true)
            {
                case bool when n % 10 == 1 && n != 11:
                    Console.WriteLine("Мы построили {0} дом", n);
                    break;

                case bool when n % 10 == 2:
                case bool when n % 10 == 3:
                case bool when n % 10 == 4:
                    Console.WriteLine("Мы построили {0} дома", n);
                    break;

                case bool when n % 10 == 0:
                case bool when n % 10 == 5:
                case bool when n % 10 == 6:
                case bool when n % 10 == 7:
                case bool when n % 10 == 8:
                case bool when n % 10 == 9:
                case bool when n > 10 && n < 15:
                    Console.WriteLine("Мы построили {0} домов", n);
                    break;

                default:
                    Console.WriteLine("Мы ничего не построили");
                    break;
            }
            Console.ReadKey();

        }
    }
}
