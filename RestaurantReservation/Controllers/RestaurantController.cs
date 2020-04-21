﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantReservation.Controllers {
    public class RestaurantController : Controller {
        private readonly ConnectionDB _db;

        public RestaurantController(ConnectionDB db) {
            _db = db;
        }
        public IActionResult Index() {
            return View();
        }

       
    }
}
