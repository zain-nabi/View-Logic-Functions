using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using View_Logic_Functions.Models;

namespace View_Logic_Functions.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var NewVehicle = new NewVehicle();

            return View(NewVehicle);
        }
    }
}
