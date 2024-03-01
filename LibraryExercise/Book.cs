using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExercise
{
    public class Book
    {
        public string Name;
        public Author Author;
        public int YearOfRelease;
        public bool IsBorrowed;
        public int BookID;
        private static int newID = 1;
        public Book()
        {

        }
        public Book(string name, Author author, int yearOfRelease)
        {
            Name = name;
            Author = author;
            YearOfRelease = yearOfRelease;
            IsBorrowed = false;
            BookID = newID;
            newID++; // So the next new book gets a new unique ID.
        }
        public void WriteBookInfo()
        {
            Console.WriteLine($"{Author.FirstName} {Author.LastName}: {Name} ({YearOfRelease})");
        }
    }
}
