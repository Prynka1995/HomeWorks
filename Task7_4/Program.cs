namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Напишите метод FindMax, который принимает переменное количество чисел и возвращает максимальное значение. Используйте ключевое слово params.

            Console.WriteLine("Введите длину массива");
            int[] nums = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Введите число N{i + 1}");
                nums[i] = (Convert.ToInt32(Console.ReadLine()));
            }

            int maxNumber = FindMax(nums);
            //int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30
            Console.ReadKey();
        }
        static int FindMax(params int[] nums)
        {
            int max = 0;
            foreach (int item in nums)
            {
                max = item > max ? item : max;
            }
            return max;
        }
    }
}
