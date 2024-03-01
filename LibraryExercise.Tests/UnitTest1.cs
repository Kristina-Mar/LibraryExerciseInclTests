namespace LibraryExercise.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddNewPatron()
        {
            string firstName = "Jane";
            string lastName = "Powell";
            Library library = new Library();
            library.AddNewPatron(firstName, lastName);
            bool wasNewPatronAdded = false;
            foreach (Patron patron in library.AllPatrons)
            {
                if (patron.FirstName == firstName && patron.LastName == lastName)
                {
                    wasNewPatronAdded = true;
                    break;
                }
            }
            Assert.True(wasNewPatronAdded);
            //library.AddNewPatron("Peter", "Scully");
            //library.AddNewPatron("Katherine", "Murray");
            //Author janeAusten = new Author("Jane", "Austen", new DateOnly(1775, 12, 16));
            //library.AddNewBook("Pride and prejudice", janeAusten, 1813);
            //Author zadieSmith = new Author("Zadie", "Smith", new DateOnly(1975, 10, 25));
            //library.AddNewBook("White teeth", zadieSmith, 2000);
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
}