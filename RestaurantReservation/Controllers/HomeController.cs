using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantReservation.Models;
using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Controllers {
    public class HomeController : Controller {
        private readonly ConnectionDB _db;


        public HomeController(ConnectionDB db) {
            _db = db;
        }

        public IEnumerable<Restaurant> Restaurantsetrecords { get; set; }
        




        public IActionResult Index() {
            
            Restaurantsetrecords = _db.Restaurants.ToList();

           Restaurant res = new Restaurant();
           



        ViewBag.Restaurants = Restaurantsetrecords;


            


            return View();
        }


        public IActionResult Reserve(int id) {
            var restaurant = _db.Restaurants.Find(id);
            if (restaurant == null) {
                return NotFound();
            }

            return View("../Restaurant/Restaurant", restaurant);
        }



        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
