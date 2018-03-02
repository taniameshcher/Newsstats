using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Model;
using WebApplication1.Model.Deserialization;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            User[] users = RestHelper.RestGet<User[]>("https://jsonplaceholder.typicode.com/users");

            ViewData["Users"] = users;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Test()
        {
            Comment[] comment = RestHelper.RestGet<Comment[]>("https://jsonplaceholder.typicode.com/comments");
            ViewData["Comment"] = comment;
            return View();
        }

        public IActionResult GoogleNews()
        {
            string keyword = "thE";
            var apiKey = Environment.GetEnvironmentVariable("GOOGLE_KEY");
            GoogleNews googleNews = RestHelper.RestGet<GoogleNews>($"https://newsapi.org/v2/top-headlines?country=us&apiKey={apiKey}");
            ArticleHandler articleHandler = new ArticleHandler(googleNews);
            articleHandler.CountByKeyword(keyword);
            ViewData["keyword"] = keyword;
            return View();
        }

        public IActionResult GoogleNewsRu()
        {
            var apiKey = Environment.GetEnvironmentVariable("GOOGLE_KEY");
            GoogleNews googleNewsRu = RestHelper.RestGet<GoogleNews>($"https://newsapi.org/v2/top-headlines?sources=google-news-ru&apiKey={apiKey}");
            ViewData["GoogleNewsRu"] = googleNewsRu;
            return View();
        }
    }
}
