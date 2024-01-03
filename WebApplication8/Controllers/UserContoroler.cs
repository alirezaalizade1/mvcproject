using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public string GetName()
        {
            return "alireza";
        }
        public string GetName1(string name)
        {
            return name;
        }
        public string GetName2(string name, string family, int age)
        {
            return "fulname : " + name + " " + family + "\n age : " + age;
        }
        public string GetName3(string name, string family, int age)
        {
            return $"fulname{name}{family}\nage : {age}";
        }
        private string MyPrivate()
        {
            return "private method";
        }
        public IActionResult GetName4()
        {
            return View();
        }
        public IActionResult GetName5(string name1)
        {
            return View("GetName5",name1);
        }
    }
}