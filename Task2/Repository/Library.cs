using System.Collections;

using Task2.Models;

namespace Task2.Repository
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;


        public Library()
        {
            books = new List<Book>();
        }


        public void AddBook(Book newBook)
        {
            books.Add(newBook);
        }

        public int RemoveBooks(Predicate<Book> param)
        {
            return books.RemoveAll(param);
        }

        public List<Book> GetBooks(Predicate<Book> param)
        {
            return books.Where(x => param(x)).ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
