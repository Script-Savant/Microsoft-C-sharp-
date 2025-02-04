using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;


namespace PartyInvites.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RsvpForm([Bind("Name, Email, Phone, WillAttend")] GuestResponse guestResponse)
    {
        Repository.AddResponse(guestResponse);
        return View("Thanks", guestResponse);
    }

    [HttpGet]
    public IActionResult ListResponses(){
        return View(Repository.Responses
        .Where(r => r.WillAttend is true));
    }
}
