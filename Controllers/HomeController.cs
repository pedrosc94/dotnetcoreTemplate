﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetcoreTemplate.Models;

namespace dotnetcoreTemplate.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Views
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult QuemSomos()
    {
        return View();
    }
    public IActionResult Cursos()
    {
        return View();
    }
    public IActionResult Contacts()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
