﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BANK_KEYS_MGMT.Controllers
{
    public class SupportTicketsController : Controller
    {

        [ActionName("ListView")]
        public IActionResult ListView()
        {
            return View();
        }

        [ActionName("TicketDetails")]
        public IActionResult TicketDetails()
        {
            return View();
        }

    }
}
