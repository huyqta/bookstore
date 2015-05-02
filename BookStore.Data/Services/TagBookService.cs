using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BookStore.Data.Context;
using BookStore.Data.Entities;
using BookStore.Data.Services.Interface;

namespace BookStore.Data.Services
{
    public class TagBookService : ITagBookService
    {
        public bool CreateTagBook(TagBook tagBook)
        {
            using (var context = new BookStoreContext())
            {
                context.TagBooks.Attach(tagBook);
                context.Entry(tagBook).State = EntityState.Added;
                return context.SaveChanges() > 0;
            }
        }

        public bool UpdateTagBook(TagBook tagBook)
        {
            using (var context = new BookStoreContext())
            {
                context.TagBooks.Attach(tagBook);
                context.Entry(tagBook).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }

        public bool DeleteTagBook(TagBook tagBook)
        {
            using (var context = new BookStoreContext())
            {
                context.TagBooks.Attach(tagBook);
                context.Entry(tagBook).State = EntityState.Deleted;
                return context.SaveChanges() > 0;
            }
        }

        public List<TagBook> GetAllTagBook()
        {
            using (var context = new BookStoreContext())
            {
                return context.TagBooks.ToList();
            }
        }
    }
}
