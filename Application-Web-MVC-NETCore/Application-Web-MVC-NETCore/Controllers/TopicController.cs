using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application_Web_MVC_NETCore.Models;
using BlogApi.Models;

namespace Application_Web_MVC_NETCore.Controllers
{
    public class TopicController : Controller
    {
        private readonly ILogger<TopicController> _logger;
        private readonly IArticleService _articleService;

        public TopicController(ILogger<TopicController> logger, IArticleService articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            var article = _articleService.GetArticle(3);
            return View(article);
        }

        public IActionResult Comments()
        {
            var articleList = _articleService.GetComments(3);
            return View(articleList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
