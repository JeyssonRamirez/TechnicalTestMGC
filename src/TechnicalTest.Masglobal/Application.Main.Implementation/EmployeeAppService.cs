//   -----------------------------------------------------------------------
//   <copyright file=EmployeeAppService.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 4:49 PM</Date>
//   <Update> 2019-01-04 - 10:44 PM</Update>
//   -----------------------------------------------------------------------

#region

using System;
using System.Linq;
using Application.Main.Definition;
using Core.DataTransferObject;
using Core.MainRepository.MasGlobal;

#endregion

namespace Application.Main.Implementation
{
    public class EmployeeAppService : IEmployeeAppService
    {
        private readonly IFactorySalaryCalculator _factorySalaryCalculator;
        private readonly IMasGlobalRepository _masGlobalRepository;

        public EmployeeAppService(IMasGlobalRepository masGlobalRepository,
            IFactorySalaryCalculator factorySalaryCalculator)
        {
            _masGlobalRepository = masGlobalRepository;
            _factorySalaryCalculator = factorySalaryCalculator;
        }


        public ResponseApi GetEmployeeWithSalary(int identification)
        {
            var response = new ResponseApi();
            try
            {
                var findedEmployees = _masGlobalRepository.GetEmployees();
                var employee = findedEmployees.FirstOrDefault(s => s.Id == identification);
                if (employee == null)
                {
                    response.Success = false;
                    response.ResponseCode = 404; // notFound
                    return response;
                }

                employee.AnnualSalary = _factorySalaryCalculator.GetCalculator(employee.ContractType)
                    .CalculateSalary(employee);
                response.Data = employee;
                response.Success = true;
                response.ResponseCode = 200; // OK
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                response.ResponseCode = 500;
            }

            return response;
        }

        public ResponseApi GetEmployeesWithSalary()
        {
            var response = new ResponseApi();
            try
            {
                var findedEmployees = _masGlobalRepository.GetEmployees();

                foreach (var employee in findedEmployees)
                {
                    employee.AnnualSalary = _factorySalaryCalculator.GetCalculator(employee.ContractType)
                        .CalculateSalary(employee);
                }

                response.Data = findedEmployees;
                response.Success = true;
                response.ResponseCode = 200; // OK
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                response.ResponseCode = 500;
            }

            return response;
        }
    }
}