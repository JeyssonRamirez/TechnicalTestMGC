//   -----------------------------------------------------------------------
//   <copyright file=MyBaseController.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 4:51 PM</Date>
//   <Update> 2019-01-05 - 12:47 AM</Update>
//   -----------------------------------------------------------------------

#region

using Core.DataTransferObject;
using Microsoft.AspNetCore.Mvc;

#endregion

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