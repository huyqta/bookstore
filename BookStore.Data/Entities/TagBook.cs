namespace BookStore.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TagBook")]
    public partial class TagBook
    {
        public Guid Id { get; set; }

        public Guid RefTag { get; set; }

        public Guid RefBook { get; set; }
    }
}
