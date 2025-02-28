namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводятся три числа.Вывести большее их них.
/*
 * switch здесь кажется избыточным.
чем больше будет чисел для сравнения, тем проще запутаться в условиях. Поэтому было бы круто придумать более или менее универсальный алгоритм, который бы легко было модифицировать для большего количества чисел. Например, можно так
int max = a;
if (b>max)
max = b;
if (c>max)
max = c;
if (d>max)
max = d;

Теперь, даже если чисел будет больше, алгоритм легко изменить и он останется довольно читаемым
*/
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c");
            int c = Convert.ToInt32(Console.ReadLine());

            switch (true)
            {
                case bool when a > b && a > c:
                    Console.WriteLine("max = {0}", a);
                    break;
                case bool when b > c:
                    Console.WriteLine("max = {0}", b);
                    break;
                default:
                    Console.WriteLine("max = {0}", c);
                    break;
            }
            Console.ReadKey();
        }
    }
}
