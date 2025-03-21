using System.Numerics;

namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Напишите метод PrintNumbers, который выводит на экран числа из массива. У метода должен быть необязательный параметр reverse, который по умолчанию равен false. Если reverse равен true, числа выводятся в обратном порядке.

            //int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Введите длину массива");
            int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Введите число N{i+1}");
                numbers[i] = (Convert.ToInt32(Console.ReadLine()));
            }

            PrintNumbers(numbers); // Вывод: 1 2 3 4 5
            Console.WriteLine();
            PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1

            Console.ReadKey();
        }
        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (reverse)
            {
                Array.Reverse(numbers);
                foreach (int number in numbers)
                {
                    Console.Write($"{number} ");
                }
            }
            else
            {
                foreach (int number in numbers)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
