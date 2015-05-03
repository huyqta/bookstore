using BookStore.Data.Entities;

namespace BookStore.Data.Context
{
    using System.Data.Entity;

    public partial class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("name=BookStoreContext")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TagBook> TagBooks { get; set; }
    }
}
