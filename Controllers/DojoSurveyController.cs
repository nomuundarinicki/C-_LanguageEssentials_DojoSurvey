using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
        [HttpPost]
        [Route("result")]
        public IActionResult result(string Name, string Languages, string Locations, string Comments)
        {
            ViewBag.Name = Name;
            ViewBag.Languages = Languages;
            ViewBag.Locations = Locations;
            ViewBag.Comments = Comments;
            
            return View("result");
        }
    }
}