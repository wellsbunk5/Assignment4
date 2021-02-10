using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Home Page will get the array of resturants check if fav dish is null and change it if it is then pass a list of strings to the cshtml page
        public IActionResult Index()
        {
            List<string> resturantList = new List<string>();

            foreach (Resturant r in Resturant.GetResturants())
            {
                string? favoriteDish = r.FavDish ?? "It's all tasty!";

                resturantList.Add($"#{r.Rank}: {r.RestName},    Favorite Dish: {favoriteDish},  Address: {r.Address},   Phone: {r.Phone},   Website: {r.Website}");

            }
            return View(resturantList);
        }
        
        [HttpGet]
        public IActionResult Suggest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggest(Suggestion resturant)
        {
            if (ModelState.IsValid)
            {
                // add sugestions to the list and then pass that list of objects to the cshtml page
                TempStorage.AddSuggestion(resturant);
                
                    return View("SuggestionList", TempStorage.Resturants);
            }
            else
            {
                return View();
            }
        }

        public IActionResult SuggestionList()
        {
            // return the list
            return View(TempStorage.Resturants);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
