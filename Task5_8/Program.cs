namespace Task5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yellow-star Сформировать одномерный массив из 5 случайных чисел из диапазона [0, 10].
            //Найти два наибольших элемента. Например, среди чисел {4, 8, 0, 9, 3} два наибольших числа – 9 и 8.
            //Среди чисел {5, 9, 1, 9, 3} два наибольших числа – 9 и 9

            const int n = 5;
            Random rnd = new Random();
            int[] a = new int[n];

            for (int i = 0; i < n; i++) // создаем массив
            {
                a[i] = rnd.Next(1, 11);
                Console.Write("{0} ", a[i]);
            }
            for (int i = 0; i < n; i++) // сортируем
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            //Console.WriteLine();
            //foreach (int item in a)
            //{
            //    Console.Write("{0} ", item);
            //}
            Console.WriteLine();
            Console.WriteLine("max1 = {0}", a[n-2]);
            Console.WriteLine("max2 = {0}", a[n-1]);
            Console.ReadKey();
        }
    }
}
