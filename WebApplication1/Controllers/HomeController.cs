using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            
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
    }
}
