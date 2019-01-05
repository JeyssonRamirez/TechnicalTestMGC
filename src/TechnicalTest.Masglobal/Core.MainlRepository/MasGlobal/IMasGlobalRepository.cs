//   -----------------------------------------------------------------------
//   <copyright file=IMasGlobalRepository.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 8:47 PM</Date>
//   <Update> 2019-01-05 - 12:47 AM</Update>
//   -----------------------------------------------------------------------

#region

using System.Collections.Generic;
using Core.DataTransferObject;

#endregion

namespace Core.MainRepository.MasGlobal
{
    public interface IMasGlobalRepository
    {
        IEnumerable<EmployeeDto> GetEmployees();
    }
}