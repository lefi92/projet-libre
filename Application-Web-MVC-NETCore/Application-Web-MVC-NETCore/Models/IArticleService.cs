using BlogApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Web_MVC_NETCore.Models
{
    public interface IArticleService
    {
        List<Article> GetAll(int page, int pageSize);

        Article GetArticle(int id);

        Article CreateArticle(Article article);

        List<Comment> GetComments(int id);

        /*Article DeleteArticle(int id);*/
    }
}
