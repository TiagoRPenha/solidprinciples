namespace BookstoreBilling
{
    public class Book
    {
        public Book(string name, string nameAuthor, int year, double price, string isbn)
        {
            Name = name;
            NameAuthor = nameAuthor;
            Year = year;
            Price = price;
            Isbn = isbn;
        }

        public string Name { get; set; }
        public string NameAuthor { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Isbn { get; set; }
    }
}
