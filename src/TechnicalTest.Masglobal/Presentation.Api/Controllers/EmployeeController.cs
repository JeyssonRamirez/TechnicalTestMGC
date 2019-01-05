//   -----------------------------------------------------------------------
//   <copyright file=EmployeeController.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 10:22 PM</Date>
//   <Update> 2019-01-04 - 10:25 PM</Update>
//   -----------------------------------------------------------------------

#region

using Application.Main.Definition;
using IoC.DependencyInjectionFactory;
using Microsoft.AspNetCore.Mvc;

#endregion

namespace Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : MyBaseController
    {
        private readonly IEmployeeAppService _appService;

        public EmployeeController()
        {
            _appService = Factory.Resolve<IEmployeeAppService>();
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var result = _appService.GetEmployeesWithSalary();
            return EvaluateCode(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _appService.GetEmployeeWithSalary(id);
            return EvaluateCode(result);
        }
    }
}