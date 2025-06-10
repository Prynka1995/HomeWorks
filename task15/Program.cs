
//Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,  частотой  работы  процессора,  объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии. Создать список, содержащий 6-10 записей с различным набором значений характеристик.

//Определить:

//- все компьютеры с указанным процессором. Название процессора запросить у пользователя;

//- все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;

//- вывести весь список, отсортированный по увеличению стоимости;

//- вывести весь список, сгруппированный по типу процессора;

//- найти самый дорогой и самый бюджетный компьютер;

//- есть ли хотя бы один компьютер в количестве не менее 30 штук?
using System.Threading.Channels;

namespace task15
{
    class PC
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CpuName { get; set; }
        public int CpuFrequency { get; set; }
        public int RamMemory { get; set; }
        public int GPUMemory { get; set; }
        public int Storage { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }

        static string InputOutputStr()
        {
            Console.WriteLine("Введите название процессора");
            return Convert.ToString(Console.ReadLine());
        }
        static int InputOutputInt()
        {
            Console.WriteLine("Введите объем ОЗУ в байтах");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void ConsoleCol(string text)
        {
            //Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{text}\n");
            Console.ResetColor();
        }
        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, CpuName={CpuName}, CpuFrequency={CpuFrequency}, RamMemory={RamMemory} GPUMemory={GPUMemory}, GPUMemory={GPUMemory}, Storage={Storage}, Cost={Cost}, Quantity={Quantity}";
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<PC> list = new List<PC>()
                {
                    new PC()
                    {
                        Id = 1,
                        Name = "Acer",
                        CpuName = "Intel Core i9",
                        CpuFrequency = 1000,
                        RamMemory = 8000,
                        GPUMemory = 2000,
                        Storage = 500,
                        Cost = 100000,
                        Quantity = 32
                    },
                    new PC()
                    {
                        Id = 2,
                        Name = "Apple",
                        CpuName = "Intel Core i7",
                        CpuFrequency = 2000,
                        RamMemory = 8000,
                        GPUMemory = 2000,
                        Storage = 500,
                        Cost = 50,
                        Quantity = 3
                    },
                    new PC()
                    {
                        Id = 3,
                        Name = "ASUS",
                        CpuName = "Intel Xeon",
                        CpuFrequency = 1500,
                        RamMemory = 16000,
                        GPUMemory = 2000,
                        Storage = 500,
                        Cost = 500,
                        Quantity = 4
                    },
                    new PC()
                    {
                        Id = 4,
                        Name = "HP",
                        CpuName = "AMD EPYC",
                        CpuFrequency = 1000,
                        RamMemory = 12000,
                        GPUMemory = 4000,
                        Storage = 750,
                        Cost = 50000,
                        Quantity = 5
                    },
                    new PC()
                    {
                        Id = 5,
                        Name = "Dell",
                        CpuName = "AMD EPYC",
                        CpuFrequency = 1000,
                        RamMemory = 8000,
                        GPUMemory = 8000,
                        Storage = 250,
                        Cost = 5000,
                        Quantity = 6
                    },
                    new PC()
                    {
                        Id = 6,
                        Name = "Gigabyte",
                        CpuName = "Intel Core i9",
                        CpuFrequency = 1000,
                        RamMemory = 9000,
                        GPUMemory = 2000,
                        Storage = 1000,
                        Cost = 750,
                        Quantity = 7
                    },
                };

                PC.ConsoleCol("Все компьютеры с указанным процессором");

                //Console.WriteLine("Все компьютеры с указанным процессором:\n");
                string cpuName = PC.InputOutputStr();
                var PCs1 = list
                   .Where(pc => pc.CpuName == cpuName);
                if (PCs1.Any())
                {
                    foreach (var item in PCs1)
                    {
                        Console.WriteLine(item);
                    }
                }
                else Console.WriteLine("Список пуст");
                Console.WriteLine("----------------------");

                PC.ConsoleCol("Все компьютеры с объемом ОЗУ не ниже, чем указано: ");
                int ramMemory = PC.InputOutputInt();
                var PCs2 = list
               .Where(pc => pc.RamMemory > ramMemory);
                if (PCs2.Any())
                {
                    foreach (var item in PCs2)
                    {
                        Console.WriteLine(item);
                    }
                }
                else Console.WriteLine("Список пуст");
                Console.WriteLine("----------------------");

                PC.ConsoleCol("Отсортированный по стоимости весь список: ");
                var PCs3 = list
                .OrderBy(pc => pc.Cost);
                if (PCs3.Any())
                {
                    foreach (var item in PCs3)
                    {
                        Console.WriteLine(item);
                    }
                }
                else Console.WriteLine("Список пуст");
                Console.WriteLine("----------------------");

                PC.ConsoleCol("Сгрупированный по типу процессора весь список: ");
                var groupedCPU = list
                .GroupBy(pc => pc.CpuName);
                if (groupedCPU.Any())
                {
                    foreach (var group in groupedCPU)
                    {
                        Console.WriteLine($"Тип процессора: {group.Key}");
                        foreach (var item in group)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                else Console.WriteLine("Список пуст");
                Console.WriteLine("----------------------");

                PC.ConsoleCol("Cамый дорогой компьютер: ");
                var MaxCost = list
                .OrderBy(pc => pc.Cost)
                .FirstOrDefault();
                if (MaxCost != null)
                {
                    Console.WriteLine(MaxCost);
                }
                else Console.WriteLine("Список пуст");
                Console.WriteLine("----------------------");

                PC.ConsoleCol("Cамый бюджетный компьютер: ");
                var MinCost = list
                .OrderByDescending(pc => pc.Cost)
                .FirstOrDefault();
                if (MaxCost != null)
                {
                    Console.WriteLine(MinCost);
                }
                else Console.WriteLine("Список пуст");
                Console.WriteLine("----------------------");

                PC.ConsoleCol("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
                var PCs4 = list
                .Where(pc => pc.Quantity > 29);
                if (PCs4.Any())
                {
                    foreach (var item in PCs4)
                    {
                        Console.WriteLine(item);
                    }
                }
                else Console.WriteLine("Список пуст");
                Console.WriteLine("----------------------");

                Console.WriteLine("END");
                Console.ReadKey();

            }
        }
    }
}

