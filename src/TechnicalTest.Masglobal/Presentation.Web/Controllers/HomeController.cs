//   -----------------------------------------------------------------------
//   <copyright file=HomeController.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 4:54 PM</Date>
//   <Update> 2019-01-05 - 12:14 AM</Update>
//   -----------------------------------------------------------------------

#region

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

#endregion

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