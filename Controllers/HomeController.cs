using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreDockerMVC.Models;

namespace AspNetCoreDockerMVC.Controllers;

[Route("/")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult HomePage()
    {
        return View("index");
    }

    [HttpGet("{Path}")]
    public IActionResult ContactPage(string Path)
    {
        if (Path == "contact")
        {
            return View("contact");
        }
        else
        {
            return View("notfound");
        }
    }
}