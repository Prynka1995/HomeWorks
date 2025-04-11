namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = rnd.Next(1000, 10000);
            Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
