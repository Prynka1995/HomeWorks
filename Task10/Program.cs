using System.Runtime.CompilerServices;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Москва", 1000, 1999);
            MultiBuilding multiBuilding = new MultiBuilding("Питер", 1000, 2001, 25, true);

            building.DisplayInfo();
            Console.WriteLine(building.CalculateTax());
            multiBuilding.DisplayInfo();
            Console.WriteLine(multiBuilding.CalculateTax());
            Console.WriteLine($"средняя площадь на этаж: {multiBuilding.AreaPerFloor} м2");

            //Upcasting(приведение производного класса к базовому)
            Building buildingUpcast = multiBuilding; //методы, свойства дочернего класса недоступны, кроме переопределнных
            Console.WriteLine("\nПосле upcasting:");
            buildingUpcast.DisplayInfo(); //вызывается переопределнный метод дочернего класса

            //Downcasting(обратное приведение с проверкой типа)
            if (buildingUpcast is MultiBuilding)
            {
                MultiBuilding multiBuilding1 = (MultiBuilding)buildingUpcast;
                Console.WriteLine("\nПосле downcasting:");
                multiBuilding1.DisplayInfo();
            }








            Console.ReadKey();
        }
        public class Building
        {
            //Поля
            protected string _adress; //модификатор protected позволяет ссылаться на поле от дочерних классов
            protected double _area;
            protected int _yearBuilt;

            //Конструктор
            public Building(string adress, double area, int yearBuilt)
            {
                _adress = adress;
                _area = area;
                _yearBuilt = yearBuilt;
            }
            //Виртуальные методы позволяют их переопределять из дочерних классов
            public virtual double CalculateTax() => _area * 1000;
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Адрес: {_adress}, площадь: {_area}, год постройки: {_yearBuilt}.");
            }

            //Свойство read only (отсутствует set)
            public int BuildingAge
            {
                get => _yearBuilt;
            }
        }
        public sealed class MultiBuilding : Building //у экземпляра MultiBuilding доступны свойства и методы класса Building
        {
            //Поля
            private int _floors;
            private bool _hasElevator;
            //Конструктор
            public MultiBuilding(string adress, double area, int yearBuilt, int floors, bool hasElevator)
            : base(adress, area, yearBuilt)
            {
                _floors = floors;
                _hasElevator = hasElevator;
            }
            //Переопределение методов
            public override double CalculateTax()
            //Повышающего коэффициента за этажи (1 + (_floors - 1) * 0.05)
            //Доплаты 5000 за наличие лифта
            {
                return _hasElevator ? 5000 + _area * 1000 * (1 + (_floors - 1) * 0.05) : _area * 1000 * (1 + (_floors - 1) * 0.05);
            }
            public override void DisplayInfo()
            {
                Console.Write($"Адрес: {_adress}, площадь: {_area}, год постройки: {_yearBuilt}, количество этажей: {_floors}, ");
                Console.Write(_hasElevator ? "есть лифт." : "нет лифта.");
                Console.WriteLine();
            }
            //Уникальный метод присущий только этому классу
            public double AreaPerFloor
            {
                get => _area / Convert.ToDouble(_floors);
            }
        }
    }
}
