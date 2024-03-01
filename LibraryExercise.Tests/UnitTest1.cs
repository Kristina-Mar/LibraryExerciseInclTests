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
        //library.AddNewPatron("Peter", "Scully");
        //library.AddNewPatron("Katherine", "Murray");
        

        //Author michaelChabon = new Author("Michael", "Chabon", new DateOnly(1963, 5, 24));
        //library.AddNewBook("The amazing adventures of Kavalier & Clay", michaelChabon, 2000);
        //library.LendBook(3, 2);
        //library.LendBook(2, 2);
        //library.LendBook(1, 2);
        //library.LendBook(3, 1);
        //library.LendBook(1, 1);
        //library.ReturnBook(1, 2);
        //library.ReturnBook(3, 2);
        //library.LendBook(3, 3);
        //library.ListAllPatrons();
    }
}