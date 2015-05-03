using System;
using System.Web.Http;
using BookStore.WebAPI.Resources;
using System.Net.Http;
using System.Net;
using BookStore.Data.Services.Interface;
using BookStore.Data.Services;
using BookStore.Data.Entities;

namespace BookStore.WebAPI.Controllers
{
    public class TagsController : ApiController
    {
        private ITagService _tagService;

        // POST api/tags
        public HttpResponseMessage Post([FromBody]Tag tag)
        {
            try
            {
                _tagService = new TagService();
                tag.Id = Guid.NewGuid();
                if (_tagService.CreateTag(tag))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, tag);
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
                _tagService = new TagService();
                var tag = _tagService.GetTagById(Guid.Parse(id));
                if (tag != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, tag);
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
                _tagService = new TagService();
                var tags = _tagService.GetAllTag();
                if (tags != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, tags);
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