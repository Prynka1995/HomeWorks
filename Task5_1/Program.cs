namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100].
         //Определить, каких чисел больше – четных или нечетных

            const int n = 10; // Размерность массива
            int[] array = new int[n]; // Инициализация массива
            Random rnd = new Random();
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                k += array[i] % 2 == 0 ? 1 : -1;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(k > 0 ? "Четных чисел больше" : k < 0 ? "Нечетных чисел больше" : "Четных и нечетных числе одинаковое количество");

            Console.ReadKey();
        }
    }
}
