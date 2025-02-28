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
            // дополнительно обрабатывать 211-219

            int a = input / 100; //сотни (первая цифра)
            int b = input % 100/10; //десятые (вторая цифра)
            int c = input % 10; //единицы (третья цифра)
            int d = input % 100; //последние 2 цифры (вторая и третья цифры)

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
                if (input > 210 && input < 220) //одинадцать - девятнадцать
                {
                    switch (d) //одинадцать - девятнадцать
                    {
                        case 11:
                            Console.Write(" одинадцать");
                            break;
                        case 12:
                            Console.Write(" двенадцать");
                            break;
                        case 13:
                            Console.Write(" тринадцать");
                            break;
                        case 14:
                            Console.Write(" четырнадцать");
                            break;
                        case 15:
                            Console.Write(" пятьнадцать");
                            break;
                        case 16:
                            Console.Write(" шестьнадцать");
                            break;
                        case 17:
                            Console.Write(" семьнадцать");
                            break;
                        case 18:
                            Console.Write(" восемьнадцать");
                            break;
                        case 19:
                            Console.Write(" девятнадцать");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
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
            }
            else Console.WriteLine("Введенное число не входит в диапазон от 100 до 999");
            Console.ReadKey();
        }
    }
}
