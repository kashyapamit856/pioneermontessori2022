using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pioneermontessori.Controllers
{
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
