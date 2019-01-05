//   -----------------------------------------------------------------------
//   <copyright file=IFactorySalaryCalculator.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 10:42 PM</Date>
//   <Update> 2019-01-05 - 12:47 AM</Update>
//   -----------------------------------------------------------------------

#region

using Core.Entities;

#endregion

namespace Application.Main.Implementation
{
    public interface IFactorySalaryCalculator
    {
        ISalaryCalculator GetCalculator(ContractType contractType);
    }
}