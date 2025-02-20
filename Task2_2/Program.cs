namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Угол а задан в градусах, минутах и секундах.Найти его величину в радианах.Рекомендации по тестированию: проверить работоспособность программы для углов, больших развернутого.
            double grad = Convert.ToDouble(Console.ReadLine());
            double min = Convert.ToDouble(Console.ReadLine());
            double sec = Convert.ToDouble(Console.ReadLine());

            double gradSum = grad + min / 60 + sec / 3600;

            //double rad = gradSum * Math.PI / 180;
            double rad = gradSum / 180;


            //Console.WriteLine(rad);
            Console.WriteLine("{0}*pi", rad);

            Console.ReadKey();
        }
    }
}
