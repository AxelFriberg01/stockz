using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StockTracker.Controllers
{
    public class TSController : Controller
    {
        [HttpGet]
        [Route("/typescript")]
        public IActionResult Typescript()
        {
            return View();
        }
    }
}