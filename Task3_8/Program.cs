namespace Task3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводится число. Вывести «Да», если оно попадает в диапазон[-10, 10], и «Нет» в противном случае.
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= -10 && a <= 10)
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
