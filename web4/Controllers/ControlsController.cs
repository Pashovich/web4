using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace web4.Controllers
{
    public class ControlsController : Controller
    {

        List<string> months = new List<string> {
                    "January",
                    "February",
                    "March",
                    "April",
                    "May",
                    "June",
                    "July",
                    "August",
                    "September",
                    "October",
                    "November"
            };


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult textBox()
        {
            return View();
        }
        [HttpPost]
        public IActionResult textBox(string text)
        {
            ViewData["Title"] = "Text Box";
            ViewData["Type"] = "text ";
            ViewData["Message"] = text;
            return View("ResultView");
        }

        [HttpGet]
        public IActionResult textArea()
        {
            return View();
        }
        [HttpPost]
        public IActionResult textArea(string text)
        {
            ViewData["Title"] = "Text Area";
            ViewData["Type"] = "text ";
            ViewData["Message"] = text;
            return View("ResultView");
        }
        [HttpGet]
        public IActionResult checkBox()
        {
            return View();
        }
        [HttpPost]
        public IActionResult checkBox(bool isSelected)
        {
            ViewData["Title"] = "Text Area";
            ViewData["Type"] = "isSelected";
            if (isSelected == true)
                ViewData["Message"] = "True";
            else
            {
                ViewData["Message"] = "False";
            }
            return View("ResultView");
        }

        [HttpGet]
        public IActionResult radio()
        {
            ViewData["months"] = this.months;
            return View();
        }
        [HttpPost]
        public IActionResult radio(bool selected)
        {
            ViewData["Title"] = "Radio";
            ViewData["Type"] = "month";
            ViewData["Message"] = Request.Form["months"];
            return View("ResultView");
        }
        [HttpGet]
        public IActionResult dropDown()
        {
            ViewData["months"] = this.months;
            return View();
        }
        [HttpPost]
        public IActionResult dropDown(bool selected)
        {
            ViewData["Title"] = "DropDown";
            ViewData["Type"] = "month";
            ViewData["Message"] = Request.Form["months"];
            return View("ResultView");
        }
        [HttpGet]
        public IActionResult listBox()
        {
            ViewData["months"] = this.months;
            return View();
        }
        [HttpPost]
        public IActionResult listBox(bool selected)
        {
            ViewData["Title"] = "ListBox";
            ViewData["Type"] = "month";
            ViewData["Message"] = Request.Form["months"];
            return View("ResultView");
        }
    }
}