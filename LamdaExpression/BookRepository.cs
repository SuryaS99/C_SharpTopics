using System.Collections.Generic;

namespace LamdaExpression
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title="Title 1", Price=3},
                new Book(){Title="Title 2", Price=24}
            };
        }

    }
}