using Task2.Repository;
using Task2.Models;

Library library = new Library();
library.AddBook(new Book("123", "123", 200, new DateTime(2006, 2, 12)));
library.AddBook(new Book("123", "123", 200, new DateTime(2006, 2, 12)));
library.AddBook(new Book("456", "567", 340, new DateTime(1998, 6, 11)));
library.AddBook(new Book("789", "789", 120, new DateTime(1970, 12, 12)));

library.RemoveBooks(x => x.Name == "456");

foreach (var book in library)
{
    Console.WriteLine(book);
}

List<Book> list = library.GetBooks(x => x.Equals(new Book("123", "123", 200, new DateTime(2006, 2, 12))));

foreach (var item in list)
{
    Console.WriteLine(item);
}
