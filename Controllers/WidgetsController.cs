﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BANK_KEYS_MGMT.Controllers
{
    public class WidgetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
