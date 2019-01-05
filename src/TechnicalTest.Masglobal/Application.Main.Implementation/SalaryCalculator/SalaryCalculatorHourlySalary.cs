//   -----------------------------------------------------------------------
//   <copyright file=SalaryCalculatorHourlySalary.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 9:50 PM</Date>
//   <Update> 2019-01-05 - 12:47 AM</Update>
//   -----------------------------------------------------------------------

#region

using Core.DataTransferObject;
using Core.Entities;

#endregion

namespace Application.Main.Implementation.SalaryCalculator
{
    public class SalaryCalculatorHourlySalary : ISalaryCalculator
    {
        public ContractType ContractType => ContractType.HourlySalaryEmployee;

        public decimal CalculateSalary(EmployeeDto employee)
        {
            return 120 * employee.HourlySalary * 12;
        }
    }
}