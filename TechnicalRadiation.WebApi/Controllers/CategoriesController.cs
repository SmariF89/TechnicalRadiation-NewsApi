using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Services;
using TechnicalRadiation.WebApi.Attributes;

namespace TechnicalRadiation.WebApi.Controllers
{
    [Route("api/categories")]
    public class CategoriesController : Controller
    {
        private readonly CategoriesService _categoriesService = new CategoriesService();

        // http://localhost:5000/api/categories/ [GET] 
        [HttpGet]
        [Route("")]
        public IActionResult GetAllCategories()
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            var result = _categoriesService.GetAllCategories(urlStr);
            if (result == null) { return StatusCode(404); }
            return Ok(result);
        }

        // http://localhost:5000/api/categories/{id:int}/ [GET] 
        [HttpGet]
        [Route("{id:int}", Name = "GetCategoryById")]
        public IActionResult GetCategoryById(int id)
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            var result = _categoriesService.GetCategoryDetailById(id, urlStr);
            if (result == null) { return StatusCode(404); }
            return Ok(result);
        }

        // http://localhost:5000/api/categories/{id:int}/ [POST]
        [Authorization]
        [HttpPost]
        [Route("")]
        public IActionResult CreateCategory([FromBody] CategoryInputModel category)
        {
            if (ModelState.IsValid)
            {
                int id = _categoriesService.CreateCategory(category);
                return CreatedAtRoute("GetCategoryById", new { id }, null);
            }
            return StatusCode(412, category);
        }

        // http://localhost:5000/api/categories/{id:int}/ [PUT]
        [Authorization]
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateCategoryById(int id, [FromBody] CategoryInputModel category)
        {
            if (ModelState.IsValid && id > 0)
            {
                string urlStr = "http://" + Request.Host.ToString() + "/";
                if (_categoriesService.UpdateCategoryById(id, category, urlStr))
                {
                    return NoContent();
                }
            }
            return StatusCode(412, category);
        }

        // http://localhost:5000/api/categories/{id:int}/ [DELETE]        
        [Authorization]
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteCategoryById(int id)
        {
            string urlStr = "http://" + Request.Host.ToString() + "/";
            if (_categoriesService.DeleteCategoryById(id, urlStr))
            {
                return NoContent();
            }
            return StatusCode(404);
        }

        // http://localhost:5000/api/categories/{categoryId:int}/newsItems/{newsItemId:int}/ [PATCH]     
        [Authorization]
        [HttpPatch]
        [Route("{categoryId:int}/newsItems/{newsItemId:int}")]
        public IActionResult LinkNewsItemToCategoryByIds(int categoryId, int newsItemId)
        {
            if (_categoriesService.LinkNewsItemToCategoryByIds(categoryId, newsItemId))
            {
                return NoContent();
            }
            return StatusCode(404);
        }
    }
}