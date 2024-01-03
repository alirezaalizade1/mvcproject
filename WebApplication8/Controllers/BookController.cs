using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models.Book;

namespace WebApplication8.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public BookController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult RegisterName()
        {
            var model = new RegisterNameViewModel();
            model.Name="GetBook";
            return View(model);
        }
        [HttpPost]
        public IActionResult RegisterName(RegisterNameViewModel model)
        {
            return View(model);
        }
        [HttpGet]
        public IActionResult RegisterFile()
        {
            var model = new RegisterFileViewModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult RegisterFile(RegisterFileViewModel model)
        {
            if (model.File.Length > 0)
            {
                using(var ms=new MemoryStream())
                {
                    model.File.CopyTo(ms);
                    var fileBytes=ms.ToArray();
                    string s =Convert.ToBase64String(fileBytes);
                    model.FileBase64 = s;
                }
            }
          return View(model);
        }

    }
}