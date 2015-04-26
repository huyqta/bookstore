using System;
using System.Collections.Generic;
using BookStore.Data.Entities;

namespace BookStore.Data.Services.Interface
{
    public interface IUserService
    {
        bool CreateUser(User book);
        bool UpdateUser(User book);
        bool DeleteUser(User book);
        User GetUserById(Guid id);
        List<User> GetAllUser();
        User Login(string username, string password);
    }
}
