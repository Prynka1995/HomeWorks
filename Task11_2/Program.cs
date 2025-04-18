namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = new IFlyable[]
            {
        new Bird(40),
        new Airplane(100, 30)
            };
            foreach (var flyable in flyables)
            {
                flyable.Fly();
            }
            Console.ReadKey();
        }
        public interface IFlyable
        {
            void Fly();
            int MaxAltitude { get; }
        }
        public class Bird : IFlyable
        {
            public int MaxAltitude { get; }
            public Bird(int MaxAltitude)
            {
                this.MaxAltitude = MaxAltitude;
            }
            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
            }
        }
        public class Airplane : IFlyable
        {
            public int CountPassengers { get; set; }
            public int MaxAltitude { get; }
            public Airplane(int maxAltitude, int countPassengers)
            {
                CountPassengers = countPassengers;
                MaxAltitude = maxAltitude;
            }
            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров.Везу {CountPassengers} пассажиров");
            }
        }
    }
}
