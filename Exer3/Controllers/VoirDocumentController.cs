using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exer3.Controllers
{
    public class VoirDocumentController : Controller
    {
        public IActionResult Index()
        {
            return File("~/documents/Horaires_des_locaux.pdf", "application/pdf");
        }
    }
}