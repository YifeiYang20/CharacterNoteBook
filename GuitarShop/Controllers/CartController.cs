using Microsoft.AspNetCore.Mvc;

namespace CharacterNoteBook.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string id)
        {
            ViewBag.UsedCharacterSlug = id;
            return View();
        }
    }
}
