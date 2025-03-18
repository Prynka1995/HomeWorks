using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Запросите у пользователя имя, возраст и город. Сформируйте строку в формате: "Имя: [имя], Возраст: [возраст], Город: [город]" с использованием StringBuilder.


            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();

            //string name = "Вася";
            //string age = "21";
            //string city = "мск";

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Имя: {name}, Возраст: {age}, Город: {city}");

            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
