﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FamilyCostKeeping.Models;

namespace FamilyCostKeeping.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["currentDate"] = DateTime.Now.ToShortDateString();
            return View();
        }        
    }
}
