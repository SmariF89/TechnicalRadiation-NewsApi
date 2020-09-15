using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;
using TechnicalRadiation.WebApi.Attributes;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/")]
    public class NewsController : Controller
    {
        private readonly NewsService _newsService = new NewsService();
        
        // http://localhost:5000/api/ [GET] 
        [HttpGet]
        [Route("")]
        public IActionResult GetAllNews([FromQuery] int pageSize = 10, [FromQuery] int pageNumber = 1)
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            var result = _newsService.GetAllNews(pageNumber, pageSize, urlStr);
            if (result == null) { return StatusCode(404); }
            return Ok(result);
        }

        // http://localhost:5000/api/{id:int}/ [GET] 
        [HttpGet]
        [Route("{id:int}", Name = "GetNewsById")]
        public IActionResult GetNewsById(int id)
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            var result = _newsService.GetNewsItemDetailById(id, urlStr);
            if (result == null) { return StatusCode(404); }
            return Ok(result);
        }

        // http://localhost:5000/api/ [POST]
        [Authorization]
        [HttpPost]
        [Route("")]
        public IActionResult CreateNewNews([FromBody] NewsItemInputModel news)
        {
            if (ModelState.IsValid)
            {
                var id = _newsService.CreateNewNews(news);
                return CreatedAtRoute("GetNewsById", new { id }, null);
            }
            return StatusCode(412, news);
        }

        // http://localhost:5000/api/{id:int}/ [PUT]
        [Authorization]
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateNewsById(int id, [FromBody] NewsItemInputModel news)
        {
            if (ModelState.IsValid && id > 0)
            {
                string urlStr = "http://" + Request.Host.ToString() + "/";
                if (_newsService.UpdateNewsById(id, news, urlStr))
                {
                    return NoContent();
                }
            }
            return StatusCode(412, news);
        }

        // http://localhost:5000/api/{id:int}/ [DELETE]
        [Authorization]
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteNewsById(int id)
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            if (_newsService.DeleteNewsById(id, urlStr))
            {
                return NoContent();
            }
            return StatusCode(404);
        }
    }
}