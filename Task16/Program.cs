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
                Thread.Sleep(500);
            }

            Console.WriteLine("\nМассив сгенерирован!");
            return array;
        }

        static int CalculateSumTask(int[] array)
        {
            Console.WriteLine("Вычисление среднего арифметического...");
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;
                Thread.Sleep(500);
            }

            return sum / array.Length;
        }
        static async Task<int[]> GenerateArrayTaskAsync()
        {
            Console.WriteLine("Генерация массива методом async...");
            int[] array = await Task.Run(() => GenerateArrayTask(8));
            Console.WriteLine("Генерация массива методом async завершена");
            return array;
        }

        static async Task<int> CalculateSumTaskAsync(int[] array)
        {
            Console.WriteLine("Вычисление среднего арифметического методом async...");
            int result = await Task.Run(() => CalculateSumTask(array));
            Console.WriteLine("Вычисление среднего арифметического методом async завершено");
            return result;
        }
        static void Main(string[] args)
        {
            //--------------------------Решение с Continuewith---------------------
            //Task<int[]> task1 = Task.Run(() => GenerateArrayTask(9));
            //Task<int> task2 = task1.ContinueWith(t =>
            //{
            //    int[] array = t.Result;
            //    return CalculateSumTask(array);
            //});
            //Console.WriteLine($"Среднее арифметическое всех чисел в массиве: {task2.Result}");
            //Console.ReadKey();

            //-----------------------Решение с async/await-----------------------------
            Console.WriteLine("Main запущен");
            int[] array = GenerateArrayTaskAsync().Result;
            int resultSum = CalculateSumTaskAsync(array).Result;
            Console.WriteLine($"сгенерированный массив: {string.Join(", ", array)}");
            Console.WriteLine($"Среднее арифметическое всех чисел в массиве: {resultSum}");
            Console.WriteLine("Main завершен");
            Console.ReadKey();



        }
    }
}
