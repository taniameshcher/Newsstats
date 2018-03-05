using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Model;
using WebApplication1.Model.Deserialization;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult GoogleNews()
        {
            ViewData["GoogleNewsCache"] = SumAccumulation.CacheDictionary;
            ViewData["Keyword"] = SumAccumulation.Keyword;
            ViewData["Sum"] = SumAccumulation.Sum;
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
