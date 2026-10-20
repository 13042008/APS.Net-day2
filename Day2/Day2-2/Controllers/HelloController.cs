using Microsoft.AspNetCore.Mvc;

namespace Day2_2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult something(int id, string context)
        {
            //return $"Hello, {id} {context}!";
            return View();
        }

        public IActionResult welcome(int id,string name)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            ViewData["message"] = $"Chao mung {name} den voi mon hoc ASP.Net core MVC";
            return View();
        }
 
    }
}
