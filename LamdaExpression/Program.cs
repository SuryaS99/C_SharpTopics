using System;

namespace LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            //books
            var books = new BookRepository().GetBooks();
            // (predicate )
            books.FindAll(IsCheaperThan10Dollers);
            var CheapBooks = books.FindAll(IsCheaperThan10Dollers);
            foreach (var book in CheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool IsCheaperThan10Dollers(Book book)
        {
            return book.Price < 10;
        }

    }
}
