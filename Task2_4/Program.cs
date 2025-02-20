namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)

        /* Task:Вводится четырехзначное число. Поменять местами 2-ую и 4-ую цифру.
         1) to string
        2) каждой цифре присвоим переменную
        3) через 3ью переменную t поменяем местами значения
        4) сложим string
        5) to int            
         */

        {
            //to string
            string input = Convert.ToString(Console.ReadLine()); // 1) to string
            //2) каждой цифре присвоим переменную
            string a = input[0].ToString();
            string b = input[1].ToString();
            string c = input[2].ToString();
            string d = input[3].ToString();

            //3) через 3ью переменную t поменяем местами значения
            string t = d;
            d = b;
            b = t;
            string result = a + b + c + d;    //сложим string

            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
