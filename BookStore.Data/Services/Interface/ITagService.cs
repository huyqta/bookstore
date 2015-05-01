using System;
using System.Collections.Generic;
using BookStore.Data.Entities;

namespace BookStore.Data.Services.Interface
{
    public interface ITagService
    {
        bool CreateTag(Tag tag);
        bool UpdateTag(Tag tag);
        bool DeleteTag(Tag tag);
        Tag GetTagById(Guid id);
        List<Tag> GetAllTag();
    }
}
