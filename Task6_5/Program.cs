using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Составить регулярное выражение для проверки корректности номера телефона. Корректный номер имеет формат +7(123)456-78-90.

            //string[] test =
            //{
            //    "+7(123)456-78-90",
            //    "892665245678",
            //    "8(1234)123-12-12",
            //    "+7(1321)132-12-54",
            //    "+7(121)234-34-34",
            //};


            Console.WriteLine("Введите номер телефона в формате +7(ххх)ххх-хх-хх");
            string str = Console.ReadLine();

            Regex regex = new Regex(@"^\+7\([0-9]{3}\)[0-9]{3}-[0-9]{2}-[0-9]{2}$");

            if (regex.IsMatch(str))
                Console.WriteLine($"{str} - ok");
            else
                Console.WriteLine($"{str} - не ok");
            Console.ReadKey();
        }
    }
}

