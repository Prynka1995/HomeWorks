namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20].
            //Определить количество положительных, отрицательных и равных нулю элементов
            const int n = 10; // Размерность массива
            int[] array = new int[n]; // Инициализация массива
            Random rnd = new Random();
            int k = 0; //положительный счетчик
            int l = 0; //отрицательный счетчик
            int p = 0; //нулевой счетчик
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20, 21);
                k += array[i] > 0 ? 1 : 0;
                l += array[i] < 0 ? 1 : 0;
                p += array[i] == 0 ? 1 : 0;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("{0} - положительных чисел, {1} - отрицательных чисел, {2} - равных нулю чисел", k, l, p);

            Console.ReadKey();
        }
    }
}
