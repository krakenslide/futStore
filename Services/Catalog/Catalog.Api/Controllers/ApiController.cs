﻿using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {   
        public IActionResult Index()
        {
            return View();
        }
    }
}
