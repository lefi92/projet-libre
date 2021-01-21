using BlogApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

using System.Net.Http;

namespace Application_Web_MVC_NETCore.Models
{
    public class ArticleService : IArticleService
    {

        private readonly HttpClient _httpClient;
        private readonly string _controllerUrl = "http://localhost:8090/api/Articles";
        public List<Article> GetAll(int page, int pageSize)
        {
            var json = _httpClient.GetStringAsync(_controllerUrl + "?pageNumber=" + page + "&pageSize=" + pageSize ).Result;
            return JsonConvert.DeserializeObject<List<Article>>(json);
        }

        public ArticleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        Article IArticleService.GetArticle(int id)
        {
            var json = _httpClient.GetStringAsync(_controllerUrl + "/" + id).Result;
            return JsonConvert.DeserializeObject<Article>(json);
        }

        Article IArticleService.CreateArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetComments(int id)
        {
            var json = _httpClient.GetStringAsync(_controllerUrl + "/" + id + "/Comment").Result;
            return JsonConvert.DeserializeObject<List<Comment>>(json);
        }

        /*Article DeleteArticle(int id);*/
    }
}
