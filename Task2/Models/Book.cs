namespace Task2.Models
{
    public class Book
    {

        public string Name { get; init; }

        public string Author { get; init; }

        public DateTime PublicDate { get; init; }

        public uint CountPage { get; init; }


        public Book(string name, string author, uint countPage, DateTime publicDate)
        {
            Name = name;
            Author = author;
            CountPage = countPage;
            PublicDate = publicDate;
        }


        public override string ToString()
        {
            return $"Автор {Author}, название {Name}, дата выпуска {PublicDate.ToShortDateString()}" +
                   $", количество страниц {CountPage.ToString()}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Book other)
            {
                return Author == other.Author && CountPage == other.CountPage &&
                       PublicDate == other.PublicDate && Name == other.Name;
            }

            return false;
        }
    }
}
