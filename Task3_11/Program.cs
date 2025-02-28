namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Можно ли на прямоугольном участке застройки размером a * b метров разместить два дома размером в плане p * q и r * s метров? Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.
            //дома можно еще "разворачивать".Т.е.для участка 2 * 10 и домов 1 * 10 и 10 * 1 ответ будет "да"

            Console.WriteLine("Введите длину участка застройки a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину участка застройки b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину дома N1 p");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину дома N1 q");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину дома N2 r");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину дома N2 s");
            int s = Convert.ToInt32(Console.ReadLine());

            if (p + r <= a && q + s <= b)
            {
                Console.WriteLine("Два дома габаритами {0}x{1} и {2}х{3} МОЖНО расположить на участке {4}х{5}", a, b, p, q, r, s);
            }
            else
            {
                Console.WriteLine("Два дома габаритами {0}x{1} и {2}х{3} НЕЛЬЗЯ расположить на участке {4}х{5}", a, b, p, q, r, s);
            }
            Console.ReadKey();
        }
    }
}
