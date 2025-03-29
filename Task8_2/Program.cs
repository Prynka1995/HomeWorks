namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            2) Напишите метод ValidateAge, проверяющий корректность возраста.Если возраст:
            //•    < 0 - выбросить ArgumentException("Возраст не может быть отрицательным"),
            //•    > 150 - выбросить ArgumentOutOfRangeException("Слишком большой возраст").

            try
            {
                Console.WriteLine("Введите возраст");
                int a = Convert.ToInt32(Console.ReadLine());
                ValidateAge(a);
                Console.WriteLine("Оптимальный возраст");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Некорректный возвраст - {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Проверка возраста завершена");
            }
            Console.ReadKey();

        }

        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");
            if (age > 150)
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
        }
    }
}
