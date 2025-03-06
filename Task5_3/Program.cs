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

            int maxValue = array[0];
            int minValue = array[0];
            int maxIndex = 0;
            int minIndex = 0;
            int index = 0;

            foreach (int a in array)
            {
                if (a > maxValue)
                {
                    maxValue = a;
                    maxIndex = index;
                }
                if (a < minValue)
                {
                    minValue = a;
                    minIndex = index;
                }
                index++;
            }
            Console.WriteLine();
            Console.WriteLine("max [index, value] = [{0},{1}], min [index, value] = [{2},{3}]",maxIndex,maxValue,minIndex,minValue);
            Console.ReadKey();
        }
    }
}
