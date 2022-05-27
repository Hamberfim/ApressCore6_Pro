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

        public ViewResult RsvpForm()
        {
            return View();
        }

    }
}