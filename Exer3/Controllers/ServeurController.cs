using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exer3.Controllers
{
    public class ServeurController : Controller
    {
        public IActionResult ListeServeurs()
        {
            return View();
        }
    }
}