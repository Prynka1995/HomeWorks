namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
            //было бы круто добавить проверку и для отрицательных двухзначных чисел
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a < -9 && a > -100) || (a > 9 && a < 100))
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

            Console.ReadKey();
        }
    }
}
