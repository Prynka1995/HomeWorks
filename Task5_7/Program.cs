namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив из 10 строк и 5 столбцов.
            //Заполнить его случайными числами в диапазоне [0, 10].
            //Определить максимальный элемент в каждой строке
            const int n = 10;
            const int m = 5;
            int[,] a = new int[n, m];
            Random rnd = new Random();
            int max = 0;

            for (int i = 0; i < n; i++) //строки
            {
                for (int j = 0; j < m; j++) //столбцы
                {
                    a[i, j] = rnd.Next(0, 11); //случайное число для каждого элемента массива
                    max = a[i, j] > max ? a[i, j] : max;
                    Console.Write("{0,3}", a[i, j]);
                }
                Console.WriteLine();
                Console.WriteLine("max = {0}", max);
                max = 0;
            }
            Console.ReadKey();
        }

    }
}
