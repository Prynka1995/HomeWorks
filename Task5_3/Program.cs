namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50].
            //Найти и вывести значение максимального, минимального элементов и их индексы
            const int n = 10; // Размерность массива
            int[] array = new int[n]; // Инициализация массива
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }

            int max = array[0];
            int min = array[0];

            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                if (a < min)
                    min = a;
            }
            Console.WriteLine();
            Console.WriteLine("max = {0}, min = {1}", max, min);
            Console.ReadKey();
        }
    }
}
