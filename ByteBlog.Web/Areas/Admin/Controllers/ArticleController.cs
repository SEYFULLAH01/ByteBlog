using AutoMapper;
using ByteBlog.Entity.DTOs.Articles;
using ByteBlog.Entity.Entities;
using ByteBlog.Service.Services.Abstractions;
using ByteBlog.Web.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ByteBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesAsync();
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await categoryService.GetAllCategoriesNonDeleted();
            return View(new ArticleAddDto { Categories = categories });
        }
        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            await articleService.CreateArticleAsync(articleAddDto);

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            RedirectToAction("Index","Article", new {Area ="Admin"});

            return View(new ArticleAddDto { Categories = categories });
        }
    }
}
