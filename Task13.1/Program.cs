namespace Example1
{
    internal class Program
    {
        // Делегат для условия фильтрации
        public delegate int Transformer(int x); //Принимаем число и возвращает число
        public static int[] Transform(int[] numbers, Transformer transformer)
        {
            //Получаем размерность массива
            int count = 0;
            foreach (var number in numbers)
            {
                transformer(number);
                count++;
            }
            //Создаем массив нужного размера
            int[] result = new int[count];
            int index = 0;
            foreach (var item in numbers)
            {
                result[index] = transformer(item);
                index++;
            }
            return result;
        }

        static void Main(string[] args)
        {
            //Использование
            var numbers = new int[] { -1, 2, 3, 4, 5 };
            var doubleNumbers = Transform(numbers, n => n * 2);
            Console.WriteLine(string.Join(",", doubleNumbers));

            var squaringNumbers = Transform(numbers, n => n * n);
            Console.WriteLine(string.Join(",", squaringNumbers));

            var moduleNumbers = Transform(numbers, n => Math.Abs(n));
            Console.WriteLine(string.Join(",", moduleNumbers));

            Console.ReadKey();

        }
    }
}