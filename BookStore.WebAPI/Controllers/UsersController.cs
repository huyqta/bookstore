﻿using System;
using System.Web.Http;
using BookStore.WebAPI.Resources;
using System.Net.Http;
using System.Net;
using BookStore.Data.Services.Interface;
using BookStore.Data.Entities;
using BookStore.Data.Services;

namespace BookStore.WebAPI.Controllers
{
    public class UsersController : ApiController
    {
        private IUserService _userService;

        public HttpResponseMessage Register([FromBody]User user)
        {
            try
            {
                _userService = new UserService();
                user.Id = Guid.NewGuid();
                if (_userService.CreateUser(user))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, user);
                }
                else
                {
                    HttpError err = new HttpError(ApiMessage.RegisterFailed);
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage GetAllUsers()
        {
            try
            {
                _userService = new UserService();
                var users = _userService.GetAllUser();
                if (users != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, users);
                }
                else
                {
                    HttpError err = new HttpError(ApiMessage.RegisterFailed);
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}