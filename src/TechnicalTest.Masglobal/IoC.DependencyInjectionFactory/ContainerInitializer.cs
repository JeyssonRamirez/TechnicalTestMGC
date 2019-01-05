//   -----------------------------------------------------------------------
//   <copyright file=ContainerInitializer.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 10:05 PM</Date>
//   <Update> 2019-01-04 - 10:59 PM</Update>
//   -----------------------------------------------------------------------

#region

using System.Collections.Generic;
using Application.Main.Definition;
using Application.Main.Implementation;
using Application.Main.Implementation.SalaryCalculator;
using Core.MainRepository.MasGlobal;
using DataAccess.MasGlobalServices;
using Unity;

#endregion

namespace IoC.DependencyInjectionFactory
{
    public static class ContainerInitializer
    {
        public static void InitializeContainer(this IUnityContainer container)
        {
            //Repositories
            container.RegisterType<IMasGlobalRepository, MasGlobalRepository>();
            //Tools


            container.RegisterType<ISalaryCalculator, SalaryCalculatorMonthlySalary>("SalaryCalculatorMonthlySalary");
            container.RegisterType<ISalaryCalculator, SalaryCalculatorHourlySalary>("SalaryCalculatorHourlySalary");

            container.RegisterType<IFactorySalaryCalculator, FactorySalaryCalculator>();

            //AppServices
            container.RegisterType<IEmployeeAppService, EmployeeAppService>();
        }
    }
}