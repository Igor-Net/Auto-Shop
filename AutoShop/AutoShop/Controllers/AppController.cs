using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoShop.Data;
using AutoShop.Services;
using AutoShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop.Controllers
{
  public class AppController : Controller
  {
    private readonly IMailService _mailService;
    private readonly IAutoRepository _repository;

    public AppController(IMailService mailService, IAutoRepository repository)
    {
      _mailService = mailService;
      _repository = repository;
    }

    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("contact")]
    public IActionResult Contact()
    {
      return View();
    }

    [HttpPost("contact")]
    public IActionResult Contact(ContactViewModel model)
    {
      if (ModelState.IsValid)
      {
        // Send the email
        _mailService.SendMessage("shawn@wildermuth.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
        ViewBag.UserMessage = "Mail Sent";
        ModelState.Clear();
      }

      return View();
    }

    public IActionResult About()
    {
      ViewBag.Title = "About Us";

      return View();
    }

    public IActionResult Shop()
    {
      return View();
    }

  }
}
