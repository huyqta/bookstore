using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BookStore.Data.Entities;
using BookStore.Data.Services;
using BookStore.Data.Services.Interface;

namespace BookStore.WebAPI.Controllers
{
    public class UsersController : ApiController
    {
        private IUserService _userService;
        public string Register([FromBody]User user)
        {
            try
            {
                _userService = new UserService();
                //UserService service = new UserService();
                user.Id = Guid.NewGuid();
                _userService.CreateUser(user);
                return user.Fullname;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}