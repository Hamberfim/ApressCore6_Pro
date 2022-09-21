//using LanguageFeatures.Models;  using in now in the GlobalUsing.cs
//using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {

            //return View(new string[] { "C#", "Language", "Features" });
            // 1. checking for null values
            Product?[] products = Product.GetProducts();
            // return View(new string[] { products[0].Name });

            // 2. guarding against null values
            //Product? p = products[0];
            //string val;
            //if (p != null)
            //{
            //    val = p.Name;
            //}
            //else
            //{
            //    val = "No Value";
            //}
            //return View(new string[] { val });

            // 3. null conditional operator
            //string? val = products[0]?.Name;
            //if (val != null)
            //{
            //    return View(new string[] { val });
            //}
            //return View(new string[] { "No Value" });

            // 4. null coalescing operator
            // return View(new string[] { products[0]?.Name ?? "No value" });

            // 5. overriding Null Analysis
            // return View(new string[] { products[0]!.Name }); // null forgiving operator - guaranteed not to be null by programmer

            // string interpolation
            // return View(new string[] { $"{products[0]?.Name} for {products[0]?.Price:c2}" });

            string[] productListings = new string[products.Length];
            for (int i = 0; i < products.Length; i++)
            {
                productListings[i] = ($"{products[i]?.Name} for {products[i]?.Price:c2}");
            }
            return View(productListings);
        }
    }
}