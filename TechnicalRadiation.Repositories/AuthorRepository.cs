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
    public class AuthorRepository
    {
        public IEnumerable<AuthorDto> GetAllAuthors(string urlStr)
        {
            return ListExtensions.ToAuthorLightWeight(DataContext.Authors, urlStr);
        }

        public AuthorDetailDto GetAuthorDetailById(int id, string urlStr)
        {
            return ListExtensions.ToAuthorDetail(DataContext.Authors.Where(x => x.Id == id).ToList(), urlStr).FirstOrDefault();
        }

        public IEnumerable<NewsItemDto> GetAuthorNewsByAuthorId(int id, string urlStr)
        {
            return ListExtensions.ToNewsItemLightWeight(DataContext.NewsItems.Where(x => x.AuthorId == id).ToList(), urlStr);
        }

        public int CreateAuthor(AuthorInputModel author)
        {
            int nextId = DataContext.Authors.Max(x => x.Id) + 1;
            Author authorToAdd = Mapper.Map<Author>(author);
            authorToAdd.Id = nextId;
            DataContext.Authors.Add(authorToAdd);
            return nextId;
        }

        public void UpdateAuthorById(int id, AuthorInputModel author)
        {
            var authorToUpdate = DataContext.Authors.Where(x => x.Id == id).SingleOrDefault();
            authorToUpdate.Name = author.Name;
            authorToUpdate.Bio = author.Bio;
            authorToUpdate.ProfileImgSource = author.ProfileImgSource;
            authorToUpdate.ModifiedBy = "authorMaker";
            authorToUpdate.ModifiedDate = DateTime.Now;
        }
        public void DeleteAuthorById(int id)
        {
            // Set all news with this category to categoryId = 0. 0 = category unset.
            DataContext.NewsItems.Where(x => x.AuthorId == id).ToList().ForEach(x => x.AuthorId = 0);
            DataContext.Authors.RemoveAll(aut => aut.Id == id);
        }

        public Boolean LinkNewsItemToAuthorByIds(int authorId, int newsItemId)
        {
            Author author = DataContext.Authors.Where(x => x.Id == authorId).SingleOrDefault();
            NewsItem newsItem = DataContext.NewsItems.Where(x => x.Id == newsItemId).SingleOrDefault();

            if (author == null || newsItem == null) { return false; }

            DataContext.NewsItems.Where(x => x.Id == newsItemId).SingleOrDefault()
                .AuthorId = authorId;

            return true;
        }
    }
}