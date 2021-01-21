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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost]
        public string Inscription([FromBody] string nom)
        {
            var user = new User();
            user.nom = nom;
            user.prenom = nom;
            user.login = nom;
            user.password = nom;
            var response = _userService.Inscription(user);
            Console.WriteLine(response);
            return response.ToString();
        }

        public IActionResult Index()
        {
            var user = _userService.GetUser(1);
            return View(user);
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
