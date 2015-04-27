using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BookStore.Data.Context;
using BookStore.Data.Entities;
using BookStore.Data.Services.Interface;

namespace BookStore.Data.Services
{
    public class UserService : IUserService
    {
        public bool CreateUser(User user)
        {
            using (var context = new BookStoreContext())
            {
                context.Users.Attach(user);
                context.Entry(user).State = EntityState.Added;
                return context.SaveChanges() > 0;
            }
        }

        public bool UpdateUser(User user)
        {
            using (var context = new BookStoreContext())
            {
                context.Users.Attach(user);
                context.Entry(user).State = EntityState.Added;
                return context.SaveChanges() > 0;
            }
        }

        public bool DeleteUser(User user)
        {
            using (var context = new BookStoreContext())
            {
                context.Users.Attach(user);
                context.Entry(user).State = EntityState.Added;
                return context.SaveChanges() > 0;
            }
        }

        public User GetUserById(Guid id)
        {
            using (var context = new BookStoreContext())
            {
                return context.Users.Find(id);
            }
        }

        public List<User> GetAllUser()
        {
            using (var context = new BookStoreContext())
            {
                return context.Users.ToList();
            }
        }

        public User Login(string username, string password)
        {
            using (var context = new BookStoreContext())
            {
                return context.Users.FirstOrDefault(u=>u.Username == username && u.Password==password);
            }
        }
    }
}
