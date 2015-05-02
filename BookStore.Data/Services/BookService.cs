﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BookStore.Data.Context;
using BookStore.Data.Entities;
using BookStore.Data.Services.Interface;

namespace BookStore.Data.Services
{
    public class BookService : IBookService
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

        public List<Book> GetLastestBook(int numberOfBook)
        {
            using (var context = new BookStoreContext())
            {
                var result = context.Books.OrderByDescending(b => b.CREDate).Take(numberOfBook).ToList();
                return result;
            }
        }

        public List<Book> SearchBookByTag(string tagName)
        {
            using (var context = new BookStoreContext())
            {
                var result = from tagbook in context.TagBooks
                             join tag in context.Tags on tagbook.RefTag equals tag.Id
                             join book in context.Books on tagbook.RefBook equals book.Id
                             where tag.TagName == tagName
                             select book;
                return result.ToList();
            }
        }

        public List<Book> SearchBookByName(string name)
        {
            using (var context = new BookStoreContext())
            {
                var result = context.Books.Where(b => b.BookName.Contains(name)).ToList();
                return result.ToList();
            }
        }
    }
}
