namespace LibraryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Patron patron1 = new Patron("Jane", "Powell");
            library.AddNewPatron(patron1);
            Patron patron2 = new Patron("Peter", "Scully");
            library.AddNewPatron(patron2);
            Patron patron3 = new Patron("Katherine", "Murray");
            Author janeAusten = new Author("Jane", "Austen", new DateOnly(1775, 12, 16));
            Book book1 = new Book("Pride and prejudice", janeAusten, 1813);
            library.AddNewBook(book1);
            Author zadieSmith = new Author("Zadie", "Smith", new DateOnly(1975, 10, 25));
            Book book2 = new Book("White teeth", zadieSmith, 2000);
            library.AddNewBook(book2);
            Author michaelChabon = new Author("Michael", "Chabon", new DateOnly(1963, 5, 24));
            Book book3 = new Book("The amazing adventures of Kavalier & Clay", michaelChabon, 2000);
            library.AddNewBook(book3);
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
