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
    public class TopicsController : Controller
    {
        private readonly ILogger<TopicsController> _logger;
        private readonly IArticleService _articleService;

        public TopicsController(ILogger<TopicsController> logger, IArticleService articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            var userList = _articleService.GetAll(1, 5);
            return View(userList);
        }

        public IActionResult IndexPage()
        {
            var userList = _articleService.GetAll(2, 5);
            return View(userList);
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
