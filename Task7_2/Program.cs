namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Создайте метод CalcCube для вычисления объема и площади поверхности куба по длине его ребра. 
            //Метод должен иметь 3 параметра - длина ребра, out-параметр для объема и out-параметр для площади поверхности.

            // Пример вызова:

            Console.WriteLine("Введите длину ребра");
            double edgeLength = Convert.ToDouble(Console.ReadLine());

            double volume, surfaceArea;

            CalcCube(edgeLength, out volume, out surfaceArea);
            Console.WriteLine($"Объем куба: {volume}"); // Объем куба: 125
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}"); // Площадь поверхности куба: 150
            
            Console.ReadKey();
        }

        static void CalcCube(double a, out double v, out double s)
        {
            s = 6 * a * a;
            v = a * a * a;
        }

    }
}
