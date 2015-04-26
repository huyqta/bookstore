using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BookStore.Data.Context;
using BookStore.Data.Entities;
using BookStore.Data.Services.Interface;

namespace BookStore.Data.Services
{
    class BookService : IBookService
    {
        public bool CreateBook(Book book)
        {
            using (var context = new BookStoreContext())
            {
                context.Books.Attach(book);
                context.Entry(book).State = EntityState.Added;
                return context.SaveChanges() > 0;
            }
        }

        public bool UpdateBook(Book book)
        {
            using (var context = new BookStoreContext())
            {
                context.Books.Attach(book);
                context.Entry(book).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }

        public bool DeleteBook(Book book)
        {
            using (var context = new BookStoreContext())
            {
                context.Books.Attach(book);
                context.Entry(book).State = EntityState.Deleted;
                return context.SaveChanges() > 0;
            }
        }

        public Book GetBookById(Guid id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Books.Find(id);
            }
        }

        public List<Book> GetAllBook()
        {
            using (var context = new BookStoreContext())
            {
                return context.Books.ToList();
            }
        }
    }
}
