using Microsoft.EntityFrameworkCore;
using System;


namespace Bookstore
{
    public class BookContext : DbContext
    {
        public BookContext() { } 

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BookstoreStock;Integrated security=True");          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
            new Book
            {
                BookId = 1,
                Isbn = "9780441013593",
                AuthorName = "Frank Herbert",
                BookName = "Dune",
                PublishYear = 1965
            },
            new Book
            {
                BookId = 2,
                Isbn = "9780593098233",
                AuthorName = "Frank Herbert",
                BookName = "Dune Messiah",
                PublishYear = 1969
            },
            new Book
            {
                BookId = 3,
                Isbn = "9780593098240",
                AuthorName = "Frank Herbert",
                BookName = "Children of Dune",
                PublishYear = 1976
            },
            new Book
            {
                BookId = 4,
                Isbn = "9780593098257",
                AuthorName = "Frank Herbert",
                BookName = "God Emperor of Dune",
                PublishYear = 1981
            },
            new Book
            {
                BookId = 5,
                Isbn = "9780593098264",
                AuthorName = "Frank Herbert",
                BookName = "Heretics of Dune",
                PublishYear = 1984
            },
            new Book
            {
                BookId = 6,
                Isbn = "9780593098271",
                AuthorName = "Frank Herbert",
                BookName = "Chapterhouse: Dune",
                PublishYear = 1985
            },
            new Book
            {
                BookId = 7,
                Isbn = "9780547928227",
                AuthorName = "J.R.R. Tolkien",
                BookName = "The Hobbit",
                PublishYear = 1937
            },
            new Book
            {
                BookId = 8,
                Isbn = "9780547928210",
                AuthorName = "J.R.R. Tolkien",
                BookName = "The Fellowship of the Ring",
                PublishYear = 1954
            },
            new Book
            {
                BookId = 9,
                Isbn = "9780547928203",
                AuthorName = "J.R.R. Tolkien",
                BookName = "The Two Towers",
                PublishYear = 1954
            },
            new Book
            {
                BookId = 10,
                Isbn = "9780547928197",
                AuthorName = "J.R.R. Tolkien",
                BookName = "The Return of the King",
                PublishYear = 1955
            },
            new Book
            {
                BookId = 11,
                Isbn = "9780307743664",
                AuthorName = "Stephen King",
                BookName = "Carrie",
                PublishYear = 1974
            },
            new Book
            {
                BookId = 12,
                Isbn = "9780345806789",
                AuthorName = "Stephen King",
                BookName = "The Shining",
                PublishYear = 1977
            },
            new Book
            {
                BookId = 13,
                Isbn = "9781982127794",
                AuthorName = "Stephen King",
                BookName = "It",
                PublishYear = 1986
            },
            new Book
            {
                BookId = 14,
                Isbn = "9781501143106",
                AuthorName = "Stephen King",
                BookName = "Misery",
                PublishYear = 1987
            },
            new Book
            {
                BookId = 15,
                Isbn = "9781501181009",
                AuthorName = "Stephen King",
                BookName = "The Outsider",
                PublishYear = 2018
            },
            new Book
            {
                BookId = 16,
                Isbn = "9781587675072",
                AuthorName = "Stephen King",
                BookName = "Salem's Lot",
                PublishYear = 1975
            },
            new Book
            {
                BookId = 17,
                Isbn = "9780743412285",
                AuthorName = "Stephen King",
                BookName = "Pet Sematary",
                PublishYear = 1983
            },
            new Book
            {
                BookId = 18,
                Isbn = "9781501143793",
                AuthorName = "Stephen King",
                BookName = "Firestarter",
                PublishYear = 1980
            },
            new Book
            {
                BookId = 19,
                Isbn = "9781439149034",
                AuthorName = "Stephen King",
                BookName = "Under the Dome",
                PublishYear = 2009
            },
            new Book
            {
                BookId = 20,
                Isbn = "9781501192265",
                AuthorName = "Stephen King",
                BookName = "The Green Mile",
                PublishYear = 1996
            },
            new Book
            {
                BookId = 21,
                Isbn = "9781451627299",
                AuthorName = "Stephen King",
                BookName = "11/22/63",
                PublishYear = 2011
            });
        }
    }
}
