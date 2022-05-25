using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        // Index Method return a ViewResult
        public ViewResult Index() 
        {
            // provide data to the view by passing arguments
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";  // tenary operator
            return View("MyView", viewModel);
        }
    }
}