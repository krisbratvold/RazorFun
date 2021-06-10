using Microsoft.AspNetCore.Mvc;
namespace Portfolio1
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult index()
        {
            return View();
        }
        [Route("/projects")]
        [HttpGet]
        public string Projects()
        {
            return "These are my projects";
        }
        [Route("/contact")]
        [HttpGet]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}