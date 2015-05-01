﻿using System;
using System.Web.Http;
using BookStore.WebAPI.Commons;
using BookStore.WebAPI.Resources;
using System.Net.Http;
using System.Net;
using BookStore.Data.Services.Interface;
using BookStore.Data.Services;
using BookStore.Data.Entities;
using System.Web.Mvc;

namespace BookStore.WebAPI.Controllers
{
    public class BooksController : ApiController
    {
        private IBookService _bookService;

        // POST api/books
        public HttpResponseMessage Post([FromBody]Book book)
        {
            try
            {
                _bookService = new BookService();
                book.Id = Guid.NewGuid();
                book.CREDate = DateTime.Now;
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

        public HttpResponseMessage Get(string id)
        {
            try
            {
                _bookService = new BookService();
                var book = _bookService.GetBookById(Guid.Parse(id));
                if (book != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, book);
                }
                else
                {
                    HttpError err = new HttpError(ApiMessage.BookNotFound);
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, err);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

        public HttpResponseMessage Get()
        {
            try
            {
                _bookService = new BookService();
                var books = _bookService.GetAllBook();
                if (books != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, books);
                }
                else
                {
                    HttpError err = new HttpError(ApiMessage.BookNotFound);
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