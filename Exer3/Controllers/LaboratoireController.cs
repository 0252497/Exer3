using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exer3.Controllers
{
    public class LaboratoireController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}