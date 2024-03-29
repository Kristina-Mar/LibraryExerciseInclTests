﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExercise
{
    public class Library
    {
        public Book[] AllBooks = new Book[100]; // Maximum number of books set to 100 for the purpose of the excercise.
        private static int bookIndex = 0;
        public Patron[] AllPatrons = new Patron[100]; // Maximum number of books set to 100 for the purpose of the excercise.
        private static int patronIndex = 0;
        public void AddNewBook(Book book)
        {
            AllBooks[bookIndex] = book;
            bookIndex++; //The program remembers where to put the next new book, aka the next free index.
        }
        public void AddNewPatron(Patron patron)
        {
            AllPatrons[patronIndex] = patron;
            patronIndex++; //The program remembers where to put the next new patron in the array, aka the next free index.
        }
        public void LendBook(Book book, Patron patron)
        {
            if (book.IsBorrowed) // A patron cannot borrow a book borrowed by someone else.
            {
                Console.WriteLine("This book is already borrowed by somebody else.");
                return;
            }
            for (int i = 0; i < patron.BorrowedBooks.Length; i++)
            {
                if (patron.BorrowedBooks[i] == null)
                {
                    patron.BorrowedBooks[i] = book;
                    break; // The cycle stops after the book is saved into a free spot.
                }
                else if (patron.BorrowedBooks[patron.BorrowedBooks.Length - 1] is not null)
                {
                    // If even the last spot is full, the patron cannot borrow any more books.
                    Console.WriteLine("You have reached the number of maximum books you can borrow, you cannot borrow this book.");
                    return;
                }
            }
            book.IsBorrowed = true;
        }
        public void ReturnBook(Book book, Patron patron)
        {
            for (int i = 0; i < patron.BorrowedBooks.Length; i++)
            {
                if (patron.BorrowedBooks[i] == book)
                {
                    patron.BorrowedBooks[i] = null;
                    break; // The cycle stops after the book is returned.
                }
                Console.WriteLine("You cannot return a book you haven't borrowed.");
                return;
            }
            book.IsBorrowed = false;
        }
        public void ListAllBooks()
        {
            for (int i = 0; i < AllBooks.Length; i++)
            {
                if (AllBooks[i] != null)
                {
                    AllBooks[i].WriteBookInfo();
                    Console.WriteLine();
                }
            }
        }
        public void ListAllPatrons()
        {
            for (int i = 0; i < AllPatrons.Length; i++)
            {
                if (AllPatrons[i] != null)
                {
                    AllPatrons[i].WritePatronInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
