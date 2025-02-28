 namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yellow-star Вводится число. Вывести его в зеркальном виде. Количество цифр в числе заранее неизвестно. Не использовать строки
            /*
             Трехзначное число int a = input / 100; //сотни (первая цифра)
            int b = input % 100/10; //десятые (вторая цифра)
            int c = input % 10; //единицы (третья (последняя) цифра)
            */

            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine()); //кол-во цифр в числе n = i

            int res = n;
            int i = 0;
            if (res == 0)
                Console.WriteLine("Количество цифр в числе = 1");
            else
            {
                while (res != 0)
                {
                    res = res / 10;
                    i++;
                }
                Console.WriteLine("Количество цифр в числе = {0}", i);
            }

            Console.Write()



            Console.ReadKey();
        }
    }
}
