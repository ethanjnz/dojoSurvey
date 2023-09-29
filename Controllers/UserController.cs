using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey.Controllers;

public class UserController : Controller
{
    // DISPLAYS THE HOME PAGE
    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }
    // POST REQUEST
    [HttpPost("/process")]
    public IActionResult Process(string Name, string Location, string Language, string Comment)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;

        return View("Details");
    }


    // DISPLAYS THE RESULTS PAGE
    // [HttpGet("results")]
    // public ViewResult Results()
    // {

    //     return View("Details");
    // }
}

