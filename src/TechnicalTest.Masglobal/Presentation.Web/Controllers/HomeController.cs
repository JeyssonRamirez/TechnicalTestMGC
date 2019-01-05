using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols;
using Presentation.Web.Models;

namespace Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppConfiguration _appConfiguration;
        public HomeController(IOptions<AppConfiguration> settings)
        {
            _appConfiguration = settings.Value;
        }
        public IActionResult Index()
        {
            ViewBag.UrlApi = _appConfiguration.UrlApi;
            return View();
        }

    }
}
