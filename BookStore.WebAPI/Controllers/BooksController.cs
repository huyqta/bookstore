using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BookStore.Data.Entities;
using BookStore.Data.Services;
using BookStore.Data.Services.Interface;
using System.Web.Helpers;
using System.Web.Mvc;
using BookStore.WebAPI.Commons;
using BookStore.WebAPI.Resources;
using System.Net.Http;
using System.Net;

namespace BookStore.WebAPI.Controllers
{
    public class BooksController : ApiController
    {
        private IBookService _bookService;
        private ApiResult apiResult;

        public HttpResponseMessage CreateBook([FromBody]Book book)
        {
            try
            {
                _bookService = new BookService();
                book.Id = Guid.NewGuid();
                if (_bookService.CreateBook(book))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, book);
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

        public HttpResponseMessage UpdateBook([FromBody]Book book)
        {
            try
            {
                _bookService = new BookService();
                if (_bookService.UpdateBook(book))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, book);
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

        public HttpResponseMessage RemoveBook([FromBody]Book book)
        {
            try
            {
                _bookService = new BookService();
                if (_bookService.DeleteBook(book))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, book);
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