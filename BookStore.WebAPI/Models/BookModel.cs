using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.WebAPI.Models
{
    public class BookModel
    {
        public string BookName { get; set; }

        public string BookTitle { get; set; }

        public string BookDescription { get; set; }

        public string Publisher { get; set; }

        public string Artist { get; set; }

        public int? Year { get; set; }

        public int? Pages { get; set; }

        public string Language { get; set; }

        public string EbookSize { get; set; }

        public string EbookFormat { get; set; }

        public string EbookUrl { get; set; }

        public string ImageUrl { get; set; }

        public string Tags { get; set; }
    }
}