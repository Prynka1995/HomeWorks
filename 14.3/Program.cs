using System.Reflection.Metadata;

namespace _14._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> userEmail = new HashSet<string>();
            userEmail.Add("alice@example.com");
            userEmail.Add("bob@example.com");
            userEmail.Add("charlie@example.com");

            Console.Write("Дубдикат charlie@example.com добавлен? ");
            Console.WriteLine(userEmail.Add("charlie@example.com") ? true : false);

            Console.Write("Есть ли \"alice@example.com\" в подписчиках? ");
            Console.WriteLine(userEmail.Contains("alice@example.com")?true:false);

            HashSet<string> newSubscribers = new HashSet<string>()
            {
            "bob@example.com",
            "dave@example.com",
            "eve@example.com"
            };

            HashSet<string> unionHashSet = new HashSet<string>(userEmail);
            unionHashSet.UnionWith(newSubscribers);//dave, eve

            Console.WriteLine("Подписчики после объединения: ");
            foreach (var item in unionHashSet)
            {
                Console.WriteLine($"- {item}");
            }

            HashSet<string> intersectHashSet = new HashSet<string>(userEmail);
            intersectHashSet.IntersectWith(newSubscribers);//bob

            Console.WriteLine("Общие подписчики: ");
            foreach (var item in intersectHashSet)
            {
                Console.WriteLine($"- {item}");
            }

            Console.Write("Удалили alice@example.com? ");
            Console.WriteLine(userEmail.Remove("alice@example.com") ? true : false);
            Console.WriteLine($"Всего подписчиков: {userEmail.Count}");

            Console.Write("userEmail является подмножеством intersectHashSet? ");
            Console.WriteLine(userEmail.IsSubsetOf(intersectHashSet) ? true : false);

            Console.Write("userEmail является надмножеством unionHashSet? ");
            Console.WriteLine(userEmail.IsSupersetOf(unionHashSet) ? true : false);

            userEmail.Clear();
            Console.WriteLine($"Подписчиков после очистки: {userEmail.Count}");


            Console.ReadKey();
        }
    }
}
