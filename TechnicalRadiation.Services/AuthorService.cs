using System;
using System.Collections.Generic;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class AuthorService
    {
        private readonly AuthorRepository _authorRepository = new AuthorRepository();

        public IEnumerable<AuthorDto> GetAllAuthors(string urlStr)
        {
            return _authorRepository.GetAllAuthors(urlStr);
        }

        public AuthorDetailDto GetAuthorDetailById(int id, string urlStr)
        {
            return _authorRepository.GetAuthorDetailById(id, urlStr);
        }

        public IEnumerable<NewsItemDto> GetAuthorNewsByAuthorId(int id, string urlStr)
        {
            return _authorRepository.GetAuthorNewsByAuthorId(id, urlStr);
        }

        public int CreateAuthor(AuthorInputModel author)
        {
            return _authorRepository.CreateAuthor(author);
        }

        public Boolean UpdateAuthorById(int id, AuthorInputModel category, string urlStr)
        {
            if (_authorRepository.GetAuthorDetailById(id, urlStr) == null) { return false; }
            _authorRepository.UpdateAuthorById(id, category);
            return true;
        }

        public Boolean DeleteAuthorById(int id, string urlStr)
        {
            if (_authorRepository.GetAuthorDetailById(id, urlStr) == null) { return false; }
            _authorRepository.DeleteAuthorById(id);
            return true;
        }

        public Boolean LinkNewsItemToAuthorByIds(int authorId, int newsItemId)
        {
            // We have to go one level deeper to validate as here we do not have access
            // to NewsItemRepository.
            return _authorRepository.LinkNewsItemToAuthorByIds(authorId, newsItemId);
        }
    }
}