﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RS1_Faktura.Controllers
{
    public class FakturaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}