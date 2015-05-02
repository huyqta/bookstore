using System;
using System.Web.Http;
using BookStore.WebAPI.Resources;
using System.Net.Http;
using System.Net;
using BookStore.Data.Services.Interface;
using BookStore.Data.Services;
using BookStore.Data.Entities;
using BookStore.WebAPI.Models;

namespace BookStore.WebAPI.Controllers
{
    public class BooksController : ApiController
    {
        private IBookService _bookService;
        private ITagService _tagService;
        private ITagBookService _tagBookService;

        // POST api/books
        public HttpResponseMessage Post([FromBody]BookModel bookModel)
        {
            try
            {
                _bookService = new BookService();
                _tagBookService = new TagBookService();
                Book book = new Book();
                AutoMapper.Mapper.CreateMap<BookModel, Book>();
                book = AutoMapper.Mapper.Map<BookModel, Book>(bookModel);
                book.Id = Guid.NewGuid();
                book.CREDate = DateTime.Now;
                
                foreach (string tag in bookModel.Tags.Split('|')){
                    TagBook tagBook = new TagBook();
                    tagBook.Id = Guid.NewGuid();
                    tagBook.RefBook = book.Id;
                    tagBook.RefTag = Guid.Parse(tag);
                    _tagBookService.CreateTagBook(tagBook);
                }
                
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

        [HttpGet]
        public HttpResponseMessage SelectLastestBook(int value)
        {
            try
            {
                _bookService = new BookService();
                var books = _bookService.GetLastestBook(value);
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