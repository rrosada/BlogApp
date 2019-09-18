using BlogApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {       
        //private IBlogService _blogService;
        //public HomeController(IBlogService blogService)
        //{
        //    _blogService = blogService;
        //}

        public IActionResult Index()
        {
            return View();
        }        
    }
}