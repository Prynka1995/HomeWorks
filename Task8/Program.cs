namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 целых числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ. Используйте обработку деления на ноль (DivideByZeroException), нечислового ввода (FormatException).
            try
            {
                Console.WriteLine("Введите число a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        Console.WriteLine(a + b);
                        break;
                    case 2:
                        Console.WriteLine(a - b);
                        break;
                    case 3:
                        Console.WriteLine(a * b);
                        break;
                    case 4:
                        Console.WriteLine(a / b);
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Введено не число - {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Деление на 0 - {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
