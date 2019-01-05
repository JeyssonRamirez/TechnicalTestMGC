//   -----------------------------------------------------------------------
//   <copyright file=FactorySalaryCalculator.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 9:49 PM</Date>
//   <Update> 2019-01-04 - 9:53 PM</Update>
//   -----------------------------------------------------------------------

#region

using System.Collections.Generic;
using System.Linq;
using Core.Entities;

#endregion

namespace Application.Main.Implementation
{
    public class FactorySalaryCalculator : IFactorySalaryCalculator
    {
        private readonly IEnumerable<ISalaryCalculator> _calculators;

        public FactorySalaryCalculator(IEnumerable<ISalaryCalculator> calculators)
        {
            _calculators = calculators;
        }

        public ISalaryCalculator GetCalculator(ContractType contractType)
        {
            return _calculators.FirstOrDefault(s => s.ContractType == contractType);
        }
    }
}