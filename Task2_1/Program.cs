namespace Task2_1
{
    internal class Program
    {
        /*
        1) Вводятся три числа.
        Обменять их местами циклически. Например, вводятся a=1, b=2, c=3. 
        После обмена в переменных должны оказаться значения a=3, b=1, c=2.    
         */
        #region Комменты 1
        //int a = 10; //Инициализация - начальное присваивание значений
        //a = 5; //Это не ициализация, это - присваивание
        //int a, b - инициализация нескольких переменных
        //a = b = 10;

        //int a = Convert.ToInt32(Console.ReadLine()); // return of Readline is String
        //int b = Convert.ToInt32(Console.ReadLine()); // return of Readline is String
        //int sum = a + b; //Ctrl+K+D - форматирование

        //Console.WriteLine("{0}+{1}={2}", a, b, sum); //Форматированный вывод, в 0 подставляется значение из sum
        //Console.Write("Нажмите любую клавишу");
        //int a = 1;
        //int b = 10 + ++a;// Результат 12
        //int b = 10 + a++;// Результат 11
        //a+=10 это a=a+10 - к текущему значению добавь 10
        #endregion

        #region Задача шар 
        /*
        int r = Convert.ToInt32(Console.ReadLine());
        double volume = 4/3*Math.PI*Math.Pow(r,3) - Результат 3,14 - потому что 4/3 целочисленное деление и получается 1
        double volume = 4.0 / 3 * Math.PI * Math.Pow(r, 3) - Нужно взять вещественную 4.0
        */
        #endregion

        #region Целочисленное деление и нет
        //int n = Convert.ToInt32(Console.ReadLine());

        //int a = n / 100; // Если n трехзначное число, например 123, то получаем первое число 1
        //int b = (n / 10) % 10; // Получаем второе число 2
        //int c = n % 10; // Получаем третье число 3

        //int n2 = c * 100 + b * 10 + a;
        //Console.WriteLine(n2);
        #endregion
        static void Main(string[] args)
        {
            // Вводятся три числа.
            // Обменять их местами циклически. Например, вводятся a = 1, b = 2, c = 3.
            // После обмена в переменных должны оказаться значения a = 3, b = 1, c = 2.
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());



            int t=a;
            a = c;
            c = b;
            b = t;

            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
            Console.WriteLine("c={0}", c);

            Console.ReadKey();
        }
    }
}
