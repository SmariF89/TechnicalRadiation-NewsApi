using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;
using TechnicalRadiation.WebApi.Attributes;

namespace TechnicalRadiation.WebApi
{
    [Route("api/authors")]
    public class AuthorController : Controller
    {
        private readonly AuthorService _authorService = new AuthorService();

        // http://localhost:5000/api/authors/ [GET] 
        [HttpGet]
        [Route("")]
        public IActionResult GetAllAuthors()
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            var result = _authorService.GetAllAuthors(urlStr);
            if (result == null) { return StatusCode(404); }
            return Ok(result);
        }

        // http://localhost:5000/api/authors/{id:int}/ [GET] 
        [HttpGet]
        [Route("{id:int}", Name = "GetAuthorById")]
        public IActionResult GetAuthorById(int id)
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            var result = _authorService.GetAuthorDetailById(id, urlStr);
            if (result == null) { return StatusCode(404); }
            return Ok(result);
        }

        // http://localhost:5000/api/authors/{id:int}/newsItems/ [GET] 
        [HttpGet]
        [Route("{id:int}/newsItems")]
        public IActionResult GetAuthorNewsByAuthorId(int id)
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            var result = _authorService.GetAuthorNewsByAuthorId(id, urlStr);
            if (result == null) { return StatusCode(404); }
            return Ok(result);
        }
        
        // http://localhost:5000/api/authors/ [POST] 
        [Authorization]
        [HttpPost]
        [Route("")]
        public IActionResult CreateAuthor([FromBody] AuthorInputModel author)
        {
            if (ModelState.IsValid)
            {
                int id = _authorService.CreateAuthor(author);
                return CreatedAtRoute("GetAuthorById", new { id }, null);
            }
            return StatusCode(412, author);
        }

        // http://localhost:5000/api/authors/{id:int}/ [PUT] 
        [Authorization]
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateAuthorById(int id, [FromBody] AuthorInputModel author)
        {
            if (ModelState.IsValid && id > 0)
            {
                string urlStr = "http://" + Request.Host.ToString() + "/";
                if (_authorService.UpdateAuthorById(id, author, urlStr))
                {
                    return NoContent();
                }
            }
            return StatusCode(412, author);
        }

        // http://localhost:5000/api/authors/{id:int}/ [DELETE] 
        [Authorization]
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteAuthorById(int id)
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            if (_authorService.DeleteAuthorById(id, urlStr))
            {
                return NoContent();
            }
            return StatusCode(404);
        }

        // http://localhost:5000/api/authors/{authorId:int}/newsItems/{newsItemId:int}/ [PATCH]         
        [Authorization]
        [HttpPatch]
        [Route("{authorId:int}/newsItems/{newsItemId:int}")]
        public IActionResult LinkNewsItemToCategoryByIds(int authorId, int newsItemId)
        {
            if (_authorService.LinkNewsItemToAuthorByIds(authorId, newsItemId))
            {
                return NoContent();
            }
            return StatusCode(404);
        }
    }
}