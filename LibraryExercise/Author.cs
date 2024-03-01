using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExercise
{
    public class Author
    {
        public string FirstName;
        public string LastName;
        public DateOnly DateOfBirth;
        public Author(string firstName, string lastName, DateOnly dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public Author(string firstName, string lastName) : this(firstName, lastName, new DateOnly(0001, 01, 01))
        {
        }
    }
}
