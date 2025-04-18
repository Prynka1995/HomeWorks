namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
            new Dog(),
            new Cat(),
            };
            foreach (var animal in animals)
            {
                animal.ShowInfo();
            }
            Console.ReadKey();
        }

        public abstract class Animal
        {
            public abstract string Name { get; }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Say();
            }
        }
        public class Dog : Animal
        {
            public override string Name => "Собака";
            public override void Say()
            {
                Console.WriteLine("Гав!");
            }
        }
        public class Cat : Animal
        {
            public override string Name => "Кошка";
            public override void Say()
            {
                Console.WriteLine("Мяу!");
            }
        }
    }
}