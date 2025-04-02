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
            catch (Exception ex)
            //Метод может вернуть ArgumentException или ArgumentOutOfRangeException, поэтому в основной программе нужно либо обрабатывать оба этих типа, либо оставить один catch, но с типом Exception 
            {
                Console.WriteLine(ex.ToString());
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
