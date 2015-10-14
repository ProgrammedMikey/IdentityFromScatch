using IdentityFromScatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityFromScatch.Controllers
{
        [Authorize(Roles = "accounting, admin")]
        public class AccountingController : Controller
        {
            // GET: Accounting
            public ActionResult Index()
            {
            if (User.IsInRole(SecurityRoles.Admin))
            {
                return Content("welcome to accounting");
            } 
            else
            {
                return Content("get back to work");
            }


            }
        }
    }
