﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Raisins.Client.Web.Models;

namespace Raisins.Client.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        
        public ActionResult Index()
        {
            BeneficiaryModel model = null;

            if (!User.Identity.IsAuthenticated)
            {
                model = BeneficiaryService.GetStatistics(Request.ServerVariables["LOGON_USER"]);
                
            }
            else
            {
                model = BeneficiaryService.GetStatistics(User.Identity.Name.ToLowerInvariant());
            }
            return View(model);
        }

    }
}