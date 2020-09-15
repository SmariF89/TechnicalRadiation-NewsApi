using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class CategoriesService
    {
        private readonly CategoriesRepository _categoriesRepository = new CategoriesRepository();

        public IEnumerable<CategoryDto> GetAllCategories(string urlStr)
        {
            // Create an envelope which will be returned.
            var allcategories = _categoriesRepository.GetAllCategories(urlStr);
            return allcategories;
        }

        public CategoryDetailsDto GetCategoryDetailById(int id, string urlStr)
        {
            CategoryDetailsDto targetCategoryItemDetail = _categoriesRepository.GetCategoryDetailItemById(id, urlStr);
            return targetCategoryItemDetail;
        }

        public int CreateCategory(CategoryInputModel category)
        {
            category.Slug = category.Name.ToLower().Replace(" ", "-");
            return _categoriesRepository.CreateCategory(category);
        }

        public Boolean UpdateCategoryById(int id, CategoryInputModel category, string urlStr)
        {
            if (_categoriesRepository.GetCategoryDetailItemById(id, urlStr) == null) { return false; }
            category.Slug = category.Name.ToLower().Replace(" ", "-");
            _categoriesRepository.UpdateCategoryById(id, category);
            return true;
        }

        public Boolean DeleteCategoryById(int id, string urlStr)
        {
            if (_categoriesRepository.GetCategoryDetailItemById(id, urlStr) == null) { return false; }
            _categoriesRepository.DeleteCategoryById(id);
            return true;
        }

        public Boolean LinkNewsItemToCategoryByIds(int categoryId, int newsItemId)
        {
            // We have to go one level deeper to validate as here we do not have access
            // to NewsItemRepository.
            return _categoriesRepository.LinkNewsItemToCategoryByIds(categoryId, newsItemId);
        }
    }
}