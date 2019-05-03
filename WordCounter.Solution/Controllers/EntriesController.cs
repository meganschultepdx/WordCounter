using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCountMachine.Models;

namespace WordCountMachine.Controllers
{
  public class EntriesController : Controller
  {

    [HttpGet("/entries")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/entries/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/entries")]
    public ActionResult Create(string userKeyWord, string userSentence)
    {
      WordCounter newWordCounter = new WordCounter(userKeyWord, userSentence);
      newWordCounter.SetUserKeyWord(userKeyWord);
      newWordCounter.SetUserSentence(userSentence);
      return View(newWordCounter);
    }

    // [HttpGet("/entries/show")]
    // public ActionResult Show()
    // {
    //   return View();
    // }

  }
}
