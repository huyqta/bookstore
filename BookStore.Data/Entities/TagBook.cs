namespace BookStore.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TagBook")]
    public partial class TagBook
    {
        public Guid Id { get; set; }

        public Guid RefTag { get; set; }

        public Guid RefBook { get; set; }
    }
}
