using _03_PartyInvites.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_PartyInvites.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);  // 'Thanks' is a razor view that guestResponse is passed to
        }

        public ViewResult ListResponses() 
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}