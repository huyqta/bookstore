namespace BookStore.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Book")]
    public partial class Book
    {
        public Guid Id { get; set; }

        [StringLength(200)]
        public string BookName { get; set; }

        [StringLength(200)]
        public string BookTitle { get; set; }

        public string BookDescription { get; set; }

        [StringLength(200)]
        public string Publisher { get; set; }

        [StringLength(200)]
        public string Artist { get; set; }

        public int? Year { get; set; }

        public int? Pages { get; set; }

        [StringLength(200)]
        public string Language { get; set; }

        [StringLength(200)]
        public string EbookSize { get; set; }

        [StringLength(200)]
        public string EbookFormat { get; set; }

        [StringLength(250)]
        public string EbookUrl { get; set; }

        [StringLength(250)]
        public string ImageUrl { get; set; }

        public DateTime? CREDate { get; set; }
    }
}
