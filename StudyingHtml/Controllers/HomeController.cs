﻿using Microsoft.AspNetCore.Mvc;

namespace StudyingHtml.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}