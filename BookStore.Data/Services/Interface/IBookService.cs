using System;
using System.Collections.Generic;
using BookStore.Data.Entities;
using System.Linq;

namespace BookStore.Data.Services.Interface
{
    public interface IBookService
    {
        bool CreateBook(Book book);
        bool UpdateBook(Book book);
        bool DeleteBook(Book book);
        Book GetBookById(Guid id);
        List<Book> GetAllBook();

        List<Book> GetLastestBook(int numberOfBook);
        List<Book> SearchBookByTag(string tagName);
        List<Book> SearchBookByName(string name);
    }
}
