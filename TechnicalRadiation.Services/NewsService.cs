using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Newtonsoft.Json;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class NewsService
    {
        private readonly NewsRepository _newsRepository = new NewsRepository();

        private Boolean getCorrectRangeWithPaging(int pageNumber, int pageSize, int listSize, ref int lowerBound, ref int range)
        {
            // Number of pages allowed is by calculated.
            double maxPagesAllowed = Math.Ceiling((listSize / (double)pageSize));
            if(pageSize > listSize) { pageSize = listSize; }
           
            // Validate if paging conditions are ok.
            if( pageSize < 1 ||
                pageSize > 25 ||
                pageNumber > maxPagesAllowed ||
                pageNumber < 1) { return false; }

            lowerBound = (pageNumber - 1) * pageSize;
            int upperBound = lowerBound + pageSize;
            range = upperBound - lowerBound;

            // Take from index to end of list.
            if (pageNumber == maxPagesAllowed) { upperBound = listSize; }

            return true;
        }

        public IEnumerable<NewsItemDto> GetAllNews(int pageNumber, int pageSize, string urlStr)
        {
            var allNews = _newsRepository.GetAllNews(urlStr);
            var listSize = allNews.Count();
            int lowerBound = 0, range = 0;
            if (allNews != null && getCorrectRangeWithPaging(pageNumber, pageSize, listSize, ref lowerBound, ref range))
            {
                allNews = allNews.ToList().GetRange(lowerBound, range);
                return allNews;
            }
            return null;
        }

        public NewsItemDetailDto GetNewsItemDetailById(int id, string urlStr)
        {
            return _newsRepository.GetNewsDetailItemById(id, urlStr);
        }

        public int CreateNewNews(NewsItemInputModel news)
        {
            return _newsRepository.CreateNewNews(news);
        }

        public Boolean UpdateNewsById(int id, NewsItemInputModel news, string urlStr) 
        {
            if (_newsRepository.GetNewsDetailItemById(id, urlStr) == null) { return false; }
            _newsRepository.UpdateNewsById(id, news);
            return true;
        }

        public Boolean DeleteNewsById(int id, string urlStr)
        {
            if (_newsRepository.GetNewsDetailItemById(id, urlStr) == null) { return false; }
            _newsRepository.DeleteNewsById(id);
            return true;
        }
    }
}