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
        return Ok(View("index"));
    }

    [HttpGet]
    public IActionResult ContactPage()
    {
        return Ok(View("contact"));
    }
}
