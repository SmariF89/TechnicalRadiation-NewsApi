using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories.Data;
using TechnicalRadiation.Repositories.Extensions;

namespace TechnicalRadiation.Repositories
{
    public class CategoriesRepository
    {
        public IEnumerable<CategoryDto> GetAllCategories(string urlStr)
        {
            return ListExtensions.ToCategoriesLightWeight(DataContext.Categories, urlStr);
        }

        public CategoryDetailsDto GetCategoryDetailItemById(int id, string urlStr)
        {
            return ListExtensions.ToCategoryDetailItem(DataContext.Categories.Where(x => x.Id == id).ToList(), urlStr).FirstOrDefault();
        }

        public int CreateCategory(CategoryInputModel category)
        {
            int nextId = DataContext.Categories.Max(x => x.Id) + 1;
            Category categoryToAdd = Mapper.Map<Category>(category);
            categoryToAdd.Id = nextId;
            DataContext.Categories.Add(categoryToAdd);
            return nextId;
        }

        public void UpdateCategoryById(int id, CategoryInputModel category)
        {
            var categoryToUpdate = DataContext.Categories.Where(x => x.Id == id).SingleOrDefault();
            categoryToUpdate.Name = category.Name;
            categoryToUpdate.Slug = category.Slug;
            categoryToUpdate.ModifiedBy = "categoryUpdater";
            categoryToUpdate.ModifiedDate = DateTime.Now;
        }

        public void DeleteCategoryById(int id)
        {
            // Set all news with this category to categoryId = 0. 0 = category unset.
            DataContext.NewsItems.Where(x => x.CategoryId == id).ToList().ForEach(x => x.CategoryId = 0);
            DataContext.Categories.RemoveAll(cat => cat.Id == id);
        }

        public Boolean LinkNewsItemToCategoryByIds(int categoryId, int newsItemId)
        {
            Category category = DataContext.Categories.Where(x => x.Id == categoryId).SingleOrDefault();
            NewsItem newsItem = DataContext.NewsItems.Where(x => x.Id == newsItemId).SingleOrDefault();

            if (category == null || newsItem == null) { return false; }

            DataContext.NewsItems.Where(x => x.Id == newsItemId).SingleOrDefault()
                .CategoryId = categoryId;

            return true;
        }
    }
}