namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 9 && a < 100)
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
