using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DorukProje.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult IsEmri()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Rapor()
        {
            return View();
        }
    }
}
