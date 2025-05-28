using System.Security.Cryptography.X509Certificates;

namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
        }
        public static Book<T,U> FindBook<T,U>(Book<T,U>[] books, T code)
        {
        foreach (Book <T,U> book in books) 
        {

        }
        public class Book<T, U>
        {
            public T Code { get; set; }
            public string Title { get; set; }
            public U PublicationYear { get; set; }
            public string Author { get; set; }
            public Book(T code, string title, U publicationYear, string author)
            {
                Code = code;
                Title = title;
                PublicationYear = publicationYear;
                Author = author;
            }
            public override string ToString()
                => $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";

        }
    }
}
