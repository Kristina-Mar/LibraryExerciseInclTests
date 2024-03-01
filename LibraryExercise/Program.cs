namespace LibraryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddNewPatron("Jane", "Powell");
            library.AddNewPatron("Peter", "Scully");
            library.AddNewPatron("Katherine", "Murray");
            Author janeAusten = new Author("Jane", "Austen", new DateOnly(1775, 12, 16));
            library.AddNewBook("Pride and prejudice", janeAusten, 1813);
            Author zadieSmith = new Author("Zadie", "Smith", new DateOnly(1975, 10, 25));
            library.AddNewBook("White teeth", zadieSmith, 2000);
            Author michaelChabon = new Author("Michael", "Chabon", new DateOnly(1963, 5, 24));
            library.AddNewBook("The amazing adventures of Kavalier & Clay", michaelChabon, 2000);
            //library.ListAllBooks();
            //library.ListAllPatrons();
            library.LendBook(3, 2);
            library.LendBook(2, 2);
            library.LendBook(1, 2);
            library.LendBook(3, 1);
            library.LendBook(1, 1);
            library.ReturnBook(1, 2);
            library.ReturnBook(3, 2);
            library.LendBook(3, 3);
            library.ListAllPatrons();
        }
    }
}
