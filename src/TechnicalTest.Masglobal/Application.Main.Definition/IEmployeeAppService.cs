//   -----------------------------------------------------------------------
//   <copyright file=IEmployeeAppService.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 4:47 PM</Date>
//   <Update> 2019-01-05 - 12:47 AM</Update>
//   -----------------------------------------------------------------------

#region

using Core.DataTransferObject;

#endregion

namespace Application.Main.Definition
{
    public interface IEmployeeAppService
    {
        ResponseApi GetEmployeeWithSalary(int identification);
        ResponseApi GetEmployeesWithSalary();
    }
}