using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExercise
{
    public class Patron
    {
        public string FirstName;
        public string LastName;
        public int PatronID;
        public Book[] BorrowedBooks = new Book[2]; // Max number of books a person can borrow.
        private static int newID = 1; // Current available Patron ID the next new patron gets assigned.
        public Patron()
        {

        }
        public Patron(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            PatronID = newID;
            newID++; // So the next new patron gets a new unique ID.
        }
        public void WritePatronInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, ID: {PatronID}");
            Console.WriteLine("Borrowed books:");
            foreach (Book book in BorrowedBooks)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Author.FirstName} {book.Author.LastName}: {book.Name} ({book.YearOfRelease})");
                }
            }
        }
    }
}
