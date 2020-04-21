using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantReservation.Controllers {
    public class UserController : Controller {
        private readonly ConnectionDB _db;


        public UserController(ConnectionDB db) {
            _db = db;
        }
        public IActionResult Index() {
            User model = new User();
            return View("Login",model);
        }
        
        public IActionResult Register(User modal) {
            return View("Register");
        }

       // [HttpPost]
        //public IActionResult Register(User modal) {
         //  return RedirectToAction("Index");
       // }

        [HttpPost]
        public IActionResult Login(User model) {

            

            //if (user != null) {
              
                return View("Dashboard",model);
                
            //}
            return NotFound();

        }
    }
}
