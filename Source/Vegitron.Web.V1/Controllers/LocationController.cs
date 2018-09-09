using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vegitron.Web.V1.Models;

namespace Vegitron.Web.V1.Controllers
{
    public class LocationController : Controller
    {
        [HttpGet]
        [Route("location/search/{areaCode}")]
        public IActionResult Search(string areaCode)
        {
            var searchLocation = new SearchResultViewModel
            {
                AreaCode = areaCode,
                Result = "Found Plot",
            };
            return View(searchLocation);
        }
    }
}