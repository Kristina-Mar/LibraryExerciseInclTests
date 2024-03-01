namespace LibraryExercise.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddNewPatron()
        {
            Library library = new Library();
            string firstName = "Jane";
            string lastName = "Powell";
            Patron newPatron = new Patron(firstName, lastName);
            library.AddNewPatron(newPatron);
            bool wasNewPatronAdded = false;
            foreach (Patron patron in library.AllPatrons)
            {
                if (patron == newPatron)
                {
                    wasNewPatronAdded = true;
                    break;
                }
            }
            Assert.True(wasNewPatronAdded);
        }
        [Fact]
        public void TestAddNewBook()
        {
            Library library = new Library();
            Author janeAusten = new Author("Jane", "Austen", new DateOnly(1775, 12, 16));
            Book newBook = new Book("Pride and prejudice", janeAusten, 1813);
            library.AddNewBook(newBook);
            bool wasNewBookAdded = false;
            foreach (Book book in library.AllBooks)
            {
                if (book == newBook)
                {
                    wasNewBookAdded = true;
                    break;
                }
            }
            Assert.True(wasNewBookAdded);
        }
        [Fact]
        public void TestLendBook()
        {
            Library library = new Library();
            Patron patron1 = new Patron("Katherine", "Murray");
            Author author1 = new Author("Jane", "Austen", new DateOnly(1775, 12, 16));
            Book book1 = new Book("Pride and prejudice", author1, 1813);
            library.LendBook(book1, patron1);
            Assert.True(book1.IsBorrowed); // Checks that the book is successfully lended.

            Patron patron2 = new Patron("Jane", "Powell");
            library.LendBook(book1, patron2);
            bool bookBorrowedToSecondPerson = false;
            for (int i = 0; i < patron2.BorrowedBooks.Length; i++)
            {
                if (patron2.BorrowedBooks[i] == book1)
                {
                    bookBorrowedToSecondPerson = true;
                    break;
                }
            }
            Assert.False(bookBorrowedToSecondPerson); // Checks that the book isn't borrowed by a second person at the same time.

            Author author2 = new Author("Zadie", "Smith", new DateOnly(1975, 10, 25));
            Book book2 = new Book("White teeth", author2, 2000);
            Author michaelChabon = new Author("Michael", "Chabon", new DateOnly(1963, 5, 24));
            Book book3 = new Book("The amazing adventures of Kavalier & Clay", michaelChabon, 2000);
            library.LendBook(book2, patron1);
            library.LendBook(book3, patron1);
            Assert.False(book3.IsBorrowed); // Checks that the patron cannot borrow more than 2 books (maximum).
        }
    }
}