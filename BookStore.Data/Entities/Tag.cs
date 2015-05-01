namespace BookStore.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        public Guid Id { get; set; }

        [Column("Tag")]
        [StringLength(50)]
        public string TagName { get; set; }
    }
}
