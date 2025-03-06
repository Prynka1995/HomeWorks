namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10].
            //Перевернуть массив, т.е. переставить элементы массива в обратном порядке

            const int n = 10; // Размерность массива
            int[] array1 = new int[n]; // Инициализация массива
            int[] array2 = new int[n]; // Инициализация массива
            int l = array2.Length;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array1[i] = rnd.Next(0, 11);
                Console.Write("{0} ", array1[i]);
            }
            Console.WriteLine();
            foreach (int a in array1)
            {
                array2[l - 1] = a;
                l--;
            }
            foreach (int a in array2)
            {
                Console.Write("{0} ", a);
            }
            Console.ReadKey();
        }
    }
}
