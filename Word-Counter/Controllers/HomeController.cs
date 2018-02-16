using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Word_Counter.Models;

namespace Word_Counter.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View("index");
        }
        [HttpPost("/")]
        public IActionResult PostIndex()
        {
            string sentenceString = Request.Form["userInputSentence"];
            string wordString = Request.Form["userInputWord"];
            RepeatCounter newCounter = new RepeatCounter(sentenceString, wordString);
            
            return View("index", newCounter);
        }
    }
}
