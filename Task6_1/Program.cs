using System.ComponentModel.DataAnnotations;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.

            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            string[] subs = s.Split(' ');
            string maxStr = "";
            int max = 0;


            foreach (var item in subs)
            {
                //Console.WriteLine(item);
                maxStr = item.Length > max ? item : maxStr;

            }
            Console.WriteLine($"Самое длинное слово - {maxStr}");


            Console.ReadKey();
        }
    }
}
