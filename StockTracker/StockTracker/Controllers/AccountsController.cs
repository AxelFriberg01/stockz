using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StockTracker.Controllers
{
    public class AccountsController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/register")]
        public IActionResult Register()
        {
            return View();
        }

        //[HttpPost]
        //[Route("/register")]
        //public IActionResult Register()
        //{
        //    return View();
        //}

        [HttpGet]
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //[Route("/login")]
        //public IActionResult Login()
        //{
        //    return View();
        //}

    }
}