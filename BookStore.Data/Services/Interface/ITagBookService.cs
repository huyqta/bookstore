using System;
using System.Collections.Generic;
using BookStore.Data.Entities;

namespace BookStore.Data.Services.Interface
{
    public interface ITagBookService
    {
        bool CreateTagBook(TagBook tagBook);
        bool UpdateTagBook(TagBook tagBook);
        bool DeleteTagBook(TagBook tagBook);
        List<TagBook> GetAllTagBook();
    }
}
