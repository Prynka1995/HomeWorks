using System.Threading.Channels;

namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте класс Book, который содержит:
            //    Поля:
            //        _title(название книги, private)
            //    _author(автор, private)
            //Автосвойства:
            //    Year(год издания, public геттер, public сеттер)
            //    Pages(количество страниц, public геттер, public сеттер)
            //Конструктор:
            //    Инициализирует все поля и свойства
            //Метод:
            //    GetInfo() – возвращает строку с информацией о книге(например: "Война и мир, Л. Толстой, 1869, 1225 стр.")

            var book = new Book("Война и мир", "Толстой", 2005, 1225);
            book.GetInfo();

            Console.ReadKey();
        }
    }
    public class Book
    {
        //Поля
        private string _title; //Название книги
        private string _author; //Автор книги
        //Автосвойства
        public int Year { get; set; } //год издания 
        public int Pages { get; set; } //количество страниц
        //Конструктор
        public Book(string title, string author, int Year, int Pages) //Конструктор
        {
            _title = title;
            _author = author;
            this.Year = Year;
            this.Pages = Pages;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{_title}, {_author}, {Year}, {Pages} стр.");
        }
    }
}
