using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirConditionerManager.Controllers
{
    public class UseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
