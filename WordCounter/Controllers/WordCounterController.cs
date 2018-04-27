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
            RepeatCounter newCounter = new RepeatCounter("word", "text", true);
            return View(newCounter);
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            RepeatCounter newCounter = new RepeatCounter(Request.Form["word"], Request.Form["moreWords"], false);
            Console.WriteLine(newCounter.GetWord());
            Console.WriteLine(newCounter.GetWords());
            Console.WriteLine(newCounter.WordCounter());

            return View("Index", newCounter);
        }
  }
}
