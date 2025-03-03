namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yellow-star Вводится число. Вывести его в зеркальном виде. Количество цифр в числе заранее неизвестно. Не использовать строк

            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine()); //

                                    #region Находим кол-во цифр
            int res = n;
            int k = 0; // k = кол-во цифр в числе n

            while (res != 0)
            {
                res = res / 10;
                k++;
            }
             #endregion

                                    #region Отзеркаливаем

            int a = 100;
            int i = 0;

            if (k == 1)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.Write(n % 10); 
            }
            while (i < k)
            {
                if (n % a / (a / 10) == 0)
                    break;
                Console.Write(n % a / (a / 10));
                i++;
                a *= 10;
            }
            Console.ReadKey();
            #endregion
        }
    }
}
