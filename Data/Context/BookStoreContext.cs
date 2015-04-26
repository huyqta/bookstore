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
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Fullname)
                .IsFixedLength();
        }
    }
}
