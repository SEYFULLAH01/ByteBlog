﻿using ByteBlog.Entity.DTOs.Articles;
using ByteBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBlog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesAsync();
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task AddAsync(ArticleAddDto articleAddDto);
    }
}
