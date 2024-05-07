

using Microsoft.AspNetCore.Mvc;

namespace MusicDownloader.controllers;

public class HomeController : Controller
{
    public ActionResult HomePage()
    {
        return View();
    }
}