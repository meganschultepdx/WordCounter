using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class EntriesController : Controller
  {

    [HttpGet("/entries")]
    public ActionResult Index()
    {
      //List<Category> allCategories = Category.GetAll();
      // return View(allCategories);
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
      Category newCategory = new Category(categoryName);
      List<Category> allCategories = Category.GetAll();
      return View("Index", allCategories);
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedCategory = Category.Find(id);
      List<Item> categoryItems = selectedCategory.GetItems();
      model.Add("category", selectedCategory);
      model.Add("items", categoryItems);
      return View(model);
    }

    // This one creates new Items within a given Category, not new Categories:
    [HttpPost("/categories/{categoryId}/items")]
    public ActionResult Create(int categoryId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      Item newItem = new Item(itemDescription);
      foundCategory.AddItem(newItem);
      List<Item> categoryItems = foundCategory.GetItems();
      model.Add("items", categoryItems);
      model.Add("category", foundCategory);
      return View("Show", model);
    }

  }
}
