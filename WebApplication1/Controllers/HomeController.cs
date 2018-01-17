using Microsoft.AspNetCore.Mvc;
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
            GoogleNews googleNews = RestHelper.RestGet<GoogleNews>("https://newsapi.org/v2/top-headlines?country=us&apiKey=edf78a83063943ffabc69e15c78e2f93");
            ViewData["GoogleNews"] = googleNews;
            return View();
        }

        public IActionResult GoogleNewsRu()
        {
            GoogleNews googleNewsRu = RestHelper.RestGet<GoogleNews>("https://newsapi.org/v2/top-headlines?sources=google-news-ru&apiKey=edf78a83063943ffabc69e15c78e2f93");
            ViewData["GoogleNewsRu"] = googleNewsRu;
            return View();
        }
    }
}
