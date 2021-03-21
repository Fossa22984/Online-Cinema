using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Online_Cinema_BLL.Services;
using Online_Cinema_BLL.Services.Interfaces;
using Online_Cinema_UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Cinema_UI.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IEmailSender _emailSender;

        public MovieController(ILogger<MovieController> logger, IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            _emailSender.SendEmailAsync("alina.cherednichenko.2000@gmail.com", "some subject", "Hello, hawayou");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
