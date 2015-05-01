using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BookStore.Data.Context;
using BookStore.Data.Entities;
using BookStore.Data.Services.Interface;

namespace BookStore.Data.Services
{
    public class TagService : ITagService
    {
        public bool CreateTag(Tag tag)
        {
            using (var context = new BookStoreContext())
            {
                context.Tags.Attach(tag);
                context.Entry(tag).State = EntityState.Added;
                return context.SaveChanges() > 0;
            }
        }

        public bool UpdateTag(Tag tag)
        {
            using (var context = new BookStoreContext())
            {
                context.Tags.Attach(tag);
                context.Entry(tag).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }

        public bool DeleteTag(Tag tag)
        {
            using (var context = new BookStoreContext())
            {
                context.Tags.Attach(tag);
                context.Entry(tag).State = EntityState.Deleted;
                return context.SaveChanges() > 0;
            }
        }

        public Tag GetTagById(Guid id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Tags.Find(id);
            }
        }

        public List<Tag> GetAllTag()
        {
            using (var context = new BookStoreContext())
            {
                return context.Tags.ToList();
            }
        }
    }
}
