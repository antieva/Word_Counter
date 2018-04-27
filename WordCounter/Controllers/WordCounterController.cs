using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounterApp;
using System;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(null);
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            RepeatCounter newCounter = new RepeatCounter(Request.Form["word"], Request.Form["moreWords"]);
            Console.WriteLine(newCounter.GetWord());
            Console.WriteLine(newCounter.GetWords());
            Console.WriteLine(newCounter.WordCounter());

            return View("Index", newCounter);
        }
  }
}
