using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataTransferObject;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Api.Controllers
{

    public class MyBaseController : ControllerBase
    {
        protected IActionResult EvaluateCode(ResponseApi data)
        {
            if (!data.Success) return BadRequest(data);
            switch (data.ResponseCode)
            {
                case 200:
                    return Ok(data);
                case 404:
                    return NotFound(data);
                case 500:
                    return Conflict(data);
                default:
                    return BadRequest(data);
            }
        }
    }
}
