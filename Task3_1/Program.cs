namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        //Вводятся два числа.Сравнить их и вывести правильный знак «<», «>» или «=».
        {
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            string result;

            if (a == b)
            {
                result = "=";
            }
            else if (a > b)
            {
                result = ">";
            }
            else
            {
                result = "<";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
