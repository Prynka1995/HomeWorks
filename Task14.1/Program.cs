namespace Task14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> players = new List<string>();
            players.Add("Иванов");
            players.Add("Петров");
            players.Add("Сидоров");

            players.Insert(1, "Козлов");
            Console.Write("Есть ли игрок 'Петров' в команде? ");
            Console.WriteLine(players.Contains("Петров") ? "True" : "False");

            players.Remove("Сидоров");

            Console.WriteLine($"Индекс игрока 'Козлов': {players.IndexOf("Козлов")}");

            players.Sort();

            Console.WriteLine("Текущий состав команды: ");
            int index = 1;
            foreach (var item in players)
            {
                //Console.WriteLine();
                Console.WriteLine($"{index}. {item}");
                index++;
            }

            Console.Write("Команда пуста? ");
            Console.WriteLine(players.Count>0?false:true);

            players.Clear();
            Console.WriteLine($"Количество игроков после очистки: {players.Count}");


            Console.ReadKey();
        }
    }
}
