using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web4.Controllers
{
    public class ResetController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Email";
            ViewBag.Action = "Send";
            ViewBag.Action2 = "toCheck";
            ViewBag.ActionName = "I have a code";
            ViewBag.display = true;
            return View();
        }
        [HttpPost]
        public IActionResult Index(string data, string action, string action2)
        {
            if(action == "Send")
            {
                //send code
                ViewBag.display = true;
                ViewBag.Title = "Email";
                ViewBag.Action2 = "toCheck";
                ViewBag.ActionName = "I have a code";
                return View();
            }
            if (action2 == "toCheck")
            {
                ViewBag.Title = "Code";
                ViewBag.display = false;
                ViewBag.Action2 = "Verify";
                ViewBag.ActionName = "Verify";
            }
            if(action2 == "Verify")
            {
                //verify
                ViewBag.display = true;
                ViewBag.Title = "Email";
                ViewBag.Action = "Send";
                ViewBag.Action2 = "toCheck";
                ViewBag.ActionName = "I have a code";
                return View();// return to view with reset
            }
            return View();
        }
    }
}