namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(звезда)  Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.

            Console.WriteLine("Введите число от 100 до 999");
            int input = Convert.ToInt32(Console.ReadLine());
            //int input = 256;

            int a = input / 100; //сотни (первая цифра)
            int b = input % 100/10; //десятые (вторая цифра)
            int c = input % 10; //единицы (третья цифра)

            if (input >= 100 && input <= 999)
            {
                switch (a) //сотни
                {
                    case 1:
                        Console.Write("сто");
                        break;
                    case 2:
                        Console.Write("двести");
                        break;
                    case 3:
                        Console.Write("триста");
                        break;
                    case 4:
                        Console.Write("четыреста");
                        break;
                    case 5:
                        Console.Write("пятьсот");
                        break;
                    case 6:
                        Console.Write("шестьсот");
                        break;
                    case 7:
                        Console.Write("семьсот");
                        break;
                    case 8:
                        Console.Write("восемьсот");
                        break;
                    case 9:
                        Console.Write("девятьсот");
                        break;
                    default:
                        break;
                }
                switch (b) //десятки
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write(" десять");
                        break;
                    case 2:
                        Console.Write(" двадцать");
                        break;
                    case 3:
                        Console.Write(" тридцать");
                        break;
                    case 4:
                        Console.Write(" сорок");
                        break;
                    case 5:
                        Console.Write(" пятьдесят");
                        break;
                    case 6:
                        Console.Write(" шестьдесят");
                        break;
                    case 7:
                        Console.Write(" семьдесят");
                        break;
                    case 8:
                        Console.Write(" восемьдесят");
                        break;
                    case 9:
                        Console.Write(" девяносто");
                        break;
                    default:
                        break;
                }
                switch (c) //едицицы
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write(" один");
                        break;
                    case 2:
                        Console.Write(" два");
                        break;
                    case 3:
                        Console.Write(" три");
                        break;
                    case 4:
                        Console.Write(" четыре");
                        break;
                    case 5:
                        Console.Write(" пять");
                        break;
                    case 6:
                        Console.Write(" шесть");
                        break;
                    case 7:
                        Console.Write(" семь");
                        break;
                    case 8:
                        Console.Write(" восемь");
                        break;
                    case 9:
                        Console.Write(" девять");
                        break;
                    default:
                        break;
                }
            }
            else Console.WriteLine("Введенное число не входит в диапазон от 100 до 999");
            Console.ReadKey();
        }
    }
}
