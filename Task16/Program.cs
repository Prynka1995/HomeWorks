namespace Task16
{
    internal class Program
    {
        //Разработать метод для формирования массива и метод для расчета среднего арифметического всех чисел в массиве (в методах сделать искусственную задержку - имитация длительных вычислений). В методе Main выполнить проверку работы методов 2мя способами - сначала используя задачи продолжения, затем - с помощью async/await 
        static int[] GenerateArrayTask(int size)
        {
            Console.WriteLine("Генерация массива...");
            var random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
                Console.Write($"{array[i]} ");
                Thread.Sleep(1000);
            }

            Console.WriteLine("\nМассив сгенерирован!");
            return array;
        }

        static int CalculateSumTask(int[] array)
        {
            Console.WriteLine("Вычисление суммы...");
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;
                Thread.Sleep(800);
            }

            return sum/array.Length;
        }
        static void Main(string[] args)
        {

        }
    }
}
