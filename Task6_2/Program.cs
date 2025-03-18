namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Составить программу, определяющую, является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).

            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();

            s = s.ToLower().Replace(" ", "");
            bool f = true;


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals(s[^(i + 1)]))
                {
                    continue;
                }
                else
                {
                    f = false;
                    break;
                }
            }
            Console.Write($"{s} - это ");
            Console.WriteLine(f ? "палиндром" : "не палиндром");

            Console.ReadKey();
        }
    }
}
