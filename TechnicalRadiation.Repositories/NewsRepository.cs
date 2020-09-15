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
    public class NewsRepository
    {
        public IEnumerable<NewsItemDto> GetAllNews(string urlStr)
        {
            return ListExtensions.ToNewsItemLightWeight(DataContext.NewsItems, urlStr);
        }

        public NewsItemDetailDto GetNewsDetailItemById(int id, string urlStr)
        {
            return ListExtensions.ToNewsItemDetail(DataContext.NewsItems.Where(x => x.Id == id).ToList(), urlStr).FirstOrDefault();
        }

        public int CreateNewNews(NewsItemInputModel news)
        {
            int nextId = DataContext.NewsItems.Max(x => x.Id) + 1;
            NewsItem itemToAdd = Mapper.Map<NewsItem>(news);
            itemToAdd.Id = nextId;
            DataContext.NewsItems.Add(itemToAdd);
            return nextId;
        }

        public void UpdateNewsById(int id, NewsItemInputModel news)
        {
            var itemToUpdate = DataContext.NewsItems.Where(x => x.Id == id).SingleOrDefault();
            itemToUpdate.Title = news.Title;
            itemToUpdate.ImgSource = news.ImgSource;
            itemToUpdate.ShortDescription = news.ShortDescription;
            itemToUpdate.LongDescription = news.LongDescription;
            itemToUpdate.PublishDate = news.PublishDate;
            itemToUpdate.ModifiedDate = DateTime.Now;
            itemToUpdate.ModifiedBy = "newsItemModifier";
        }

        public void DeleteNewsById(int id)
        {
            DataContext.NewsItems.RemoveAll(x => x.Id == id);
        }
    }
}