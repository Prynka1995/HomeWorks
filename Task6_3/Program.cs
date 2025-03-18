namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Пример данных:
        Месяц: "Март"
        Год: 2025
        Общая сумма продаж: 1234567.89
        Количество проданных товаров: 1234

    Пример отчёта:

    --------------------------------

    Отчёт о продажах за Март 2025

    --------------------------------

    Общая сумма продаж: 1 234 567,89 р.

    Количество проданных товаров: 1 234 шт.

    Средняя стоимость товара: 1 000,46 р.
             */

            Console.WriteLine("Введите месяц (например \"Март\" без кавычек)");
            string month = Console.ReadLine();
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите общую сумму продаж в формате хххх,хх: ");
            double sells1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество проданных товаров в формате хххх:");
            int sells2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите среднюю стоимость товара в формате хххх,хх:");
            double sells3 = Convert.ToDouble(Console.ReadLine());

            //string month = "Март";
            //int year = 2025;
            //double sells1 = 1234567.90;
            //int sells2 = 1234;
            //int sells3 = 1234;

            string output = string.Empty;
            string s1 = new String('-', 37);
            output = String.Format($"\n\n{s1}\n\n", output);
            output += String.Format($"Отчет о продажах за {month} {year}\n\n{s1}\n\n");
            output += String.Format($"Общая сумма продаж: {sells1:N} р.\n\n");
            output += String.Format($"Количество проданных товаров: {sells2:N0} шт.\n\n");
            output += String.Format($"Средняя стоимость товара: {sells3:N} р.\n\n{s1}\n\n");

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
