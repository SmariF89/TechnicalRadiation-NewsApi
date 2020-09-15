using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Newtonsoft.Json.Linq;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Repositories.Data;

namespace TechnicalRadiation.Repositories.Extensions
{
    public static class ListExtensions
    {
        private static ExpandoObject getHrefObj(string hrefStr)
        {
            ExpandoObject insideExpObj = new ExpandoObject();
            insideExpObj.AddReference("href", hrefStr);
            return insideExpObj;
        }

        // NewsItems
        private static ExpandoObject getNewsLinks(string urlStr, int newsId, int authorId, int categoryId)
        {
            ExpandoObject expObj = new ExpandoObject();
            expObj.AddReference("self", getHrefObj(urlStr + "api/" + newsId.ToString()));
            expObj.AddReference("edit", getHrefObj(urlStr + "api/" + newsId.ToString()));
            expObj.AddReference("delete", getHrefObj(urlStr + "api/" + newsId.ToString()));
            expObj.AddReference("authors", getHrefObj(urlStr + "api/authors/" + authorId.ToString()));
            expObj.AddReference("categories", getHrefObj(urlStr + "api/categories/" + categoryId.ToString()));
            return expObj;
        }

        public static List<NewsItemDto> ToNewsItemLightWeight(this List<NewsItem> newsItemList, string urlStr) => newsItemList.OrderByDescending(n => n.PublishDate).Select(item => new NewsItemDto
        {
            Id = item.Id,
            Title = item.Title,
            ImgSource = item.ImgSource,
            ShortDescription = item.ShortDescription,
            Links = getNewsLinks(urlStr, item.Id, item.AuthorId, item.CategoryId)
        }).ToList();

        public static List<NewsItemDetailDto> ToNewsItemDetail(this List<NewsItem> newsItemList, string urlStr) => newsItemList.Select(item => new NewsItemDetailDto
        {
            Id = item.Id,
            Title = item.Title,
            ImgSource = item.ImgSource,
            ShortDescription = item.ShortDescription,
            LongDescription = item.LongDescription,
            PublishDate = item.PublishDate,
            Links = getNewsLinks(urlStr, item.Id, item.AuthorId, item.CategoryId)
        }).ToList();

        // Authors
        private static JObject[] GetHrefArray(string hrefStr, List<int> newsIds)
        {
            JObject[] newsIdList = new JObject[newsIds.Count()];

            for (var i = 0; i < newsIds.Count(); i++)
            {
                newsIdList[i] = new JObject();
                newsIdList[i].Add("href", hrefStr + newsIds[i].ToString());
            }

            return newsIdList;
        }
        private static ExpandoObject GetAuthorLinks(string urlStr, int authorId, List<int> newsIds)
        {
            ExpandoObject expObj = new ExpandoObject();
            expObj.AddReference("self", getHrefObj(urlStr + "api/authors/" + authorId.ToString()));
            expObj.AddReference("edit", getHrefObj(urlStr + "api/authors/" + authorId.ToString()));
            expObj.AddReference("delete", getHrefObj(urlStr + "api/authors/" + authorId.ToString()));
            expObj.AddReference("newsItems", getHrefObj(urlStr + "api/authors/" + authorId.ToString() + "/newsItems"));
            expObj.AddReference("newsItemsDetailed", GetHrefArray(urlStr + "api/", newsIds));

            return expObj;
        }

        public static List<AuthorDto> ToAuthorLightWeight(this List<Author> authorList, string urlStr) => authorList.Select(item => new AuthorDto
        {
            Id = item.Id,
            Name = item.Name,
            Links = GetAuthorLinks(urlStr, item.Id, DataContext.NewsItems.Where(x => x.AuthorId == item.Id).Select(y => y.Id).ToList())
        }).ToList();

        public static List<AuthorDetailDto> ToAuthorDetail(this List<Author> authorList, string urlStr) => authorList.Select(item => new AuthorDetailDto
        {
            Id = item.Id,
            Name = item.Name,
            ProfileImgSource = item.ProfileImgSource,
            Bio = item.Bio,
            Links = GetAuthorLinks(urlStr, item.Id, DataContext.NewsItems.Where(x => x.AuthorId == item.Id).Select(y => y.Id).ToList())
        }).ToList();

        // Categories
        private static ExpandoObject getCategoriesLinks(string urlStr, int categoryId)
        {
            ExpandoObject expObj = new ExpandoObject();
            expObj.AddReference("self", getHrefObj(urlStr + "api/categories/" + categoryId.ToString()));
            expObj.AddReference("edit", getHrefObj(urlStr + "api/categories/" + categoryId.ToString()));
            expObj.AddReference("delete", getHrefObj(urlStr + "api/categories/" + categoryId.ToString()));
            return expObj;
        }

        public static List<CategoryDto> ToCategoriesLightWeight(this List<Category> newsItemList, string urlStr) => newsItemList.Select(item => new CategoryDto
        {
            Id = item.Id,
            Name = item.Name,
            Slug = item.Slug,
            Links = getCategoriesLinks(urlStr, item.Id)
        }).ToList();

        public static List<CategoryDetailsDto> ToCategoryDetailItem(this List<Category> newsItemList, string urlStr) => newsItemList.Select(item => new CategoryDetailsDto
        {
            Id = item.Id,
            Name = item.Name,
            Slug = item.Slug,
            NumberOfNewsItems = DataContext.NewsItems.Where(x => x.CategoryId == item.Id).Count(),
            Links = getCategoriesLinks(urlStr, item.Id)
        }).ToList();


        private static int GetNumberOfNewsItemsInCategory(int id)
        {
            return 400;
            //return DataContext.NewsItems.Where(x => x.Id == id).ToList()).FirstOrDefault()
        }
    }

}