using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace shops.web.mvc.Controllers
{
    public class shopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
