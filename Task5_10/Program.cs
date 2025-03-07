namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yellow-star Клеточное поле размером n*n (n – константа на ваш выбор) состоит из 0 («ноликов») и 1 («крестиков»). Проверить, выиграли ли «крестики»? Считается, что «крестики» выиграли, если на поле найдется горизонталь, вертикали или диагональ из «крестиков».
            #region Исходные данные
            const int n = 3;
            int l = n;
            bool f = false;
            int s1 = 0;
            int s2 = 0;
            int s3_1 = 0;
            int s3_2 = 0;


            int[,] a =
            {
            { 1, 0, 1 },
            { 0, 1, 0 },
            { 0, 0, 1 }
            };

            for (int i = 0; i < n; i++)
            {
                for (global::System.Int32 j = 0; j < n; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region Горизонталь
            //Console.WriteLine("ГОРИЗОНТАЛЬ");
            for (int i = 0; i < n; i++) //строки
            {
                for (int j = 0; j < n; j++) //столбцы
                {
                    //Console.Write("{0} ", a[i, j]);
                    s1 = a[i, j] == 1 ? ++s1 : s1;
                }
                //Console.WriteLine(s1 == n ? "крестики победили по горизонтали" : "перебираем дальше");
                if (s1 == n) break;
                else s1 = 0;

            }
            #endregion

            #region Вертикаль
            //Console.WriteLine();
            //Console.WriteLine("ВЕРТИКАЛЬ");

            for (int j = 0; j < n; j++) //столбцы
            {
                for (int i = 0; i < n; i++) //строки
                {
                    //Console.Write("{0} ", a[i, j]);
                    s2 = a[i, j] == 1 ? ++s2 : s2;
                }
                //Console.WriteLine(s2 == n ? "крестики победили по вертикали" : "перебираем дальше");
                if (s2 == n) break; 
                else s2 = 0;
            }
            #endregion

            #region Диагональ
            //Console.WriteLine();
            //Console.WriteLine("Первая ДИАГОНАЛЬ");
            for (int i = 0; i < n; i++) //строки
            {
                for (int j = 0; j < n; j++) //столбцы
                {
                    //Console.Write("{0} ", a[i, j]);
                    s3_1 = i == j && a[i, j] == 1 ? ++s3_1 : s3_1;
                }
            }
            //Console.WriteLine(s3_1 == n ? "крестики победили по первой диагонали" : "перебираем дальше");
            //Console.WriteLine();

            //Console.WriteLine("Вторая ДИАГОНАЛЬ");
            for (int i = 0; i < n; i++) //строки
            {
                for (int j = 0; j < n; j++) //столбцы
                {
                    //Console.Write("{0} ", a[i, j]);
                    s3_2 = a[i, l - 1] == 1 ? ++s3_2 : s3_2;
                    --l;
                    break;
                    //s3_1 = i == j && a[i, j] == 1 ? ++s3_1 : s3_1;
                }
            }
            //Console.WriteLine(s3_2 == n ? "крестики победили по второй диагонали" : "перебираем дальше");
            #endregion

            #region Switch
            //Console.WriteLine();
            switch (true)
            {
                case bool when s1 == n:
                case bool when s2 == n:
                case bool when s3_1 == n:
                case bool when s3_2 == n:
                    Console.WriteLine("Крестики победили");
                    break;
                default:
                    Console.WriteLine("Крестики не победили");
                    break;
            }

            #endregion
            Console.ReadKey();
        }
    }
}
