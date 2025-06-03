namespace Task14._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            //        Ноутбуки("A001") — 10 шт.
            //Смартфоны("B205") — 25 шт.
            //Наушники("C307") — 15 шт.

            //            Пример вывода:
            //Есть ли товар с артикулом B205? True
            //Количество наушников: 15
            //Текущий инвентарь:  
            //Артикул: A001, Количество: 8
            //Артикул: B205, Количество: 30
            //Инвентарь пуст? False
            //Количество товаров после очистки: 0

            dict.Add("A001", 10);//Ноутбуки
            dict.Add("B205", 25);//Смартфоны
            dict.Add("C307", 15);//Наушники

            Console.Write("Есть ли товар с артикулом B205?");
            Console.WriteLine(dict.ContainsKey("B205") ? true : false);

            dict["A001"] = 8;

            dict.TryGetValue("C307", out int value);

            Console.WriteLine($"Количество наушников: {dict["C307"]}");

            dict["B205"] += 5;

            dict.Remove("C307");

            Console.WriteLine("Текущий инвентарь: ");
            foreach (var item in dict)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }
            Console.Write("Инвентарь пуст? ");
            Console.WriteLine(dict.Count > 0 ? false : true);

            dict.Clear();

            Console.WriteLine($"Количество товаров после очистки: {dict.Count}");

            Console.ReadKey();
        }
    }
}
