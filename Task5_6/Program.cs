namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать двумерный массив вида
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1
            const int n = 5;
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)//четные строки, включая ноль
                    {
                        array[i, j] = j % 2 == 0 ? 1 : 0; //четные столбцы, включая ноль
                        Console.Write("{0} ", array[i, j]);
                    }
                    else ////нечетные строки
                    {
                        array[i, j] = j % 2 == 0 ? 0 : 1; //четные столбцы, включая ноль
                        Console.Write("{0} ", array[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
