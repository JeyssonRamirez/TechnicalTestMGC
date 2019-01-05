//   -----------------------------------------------------------------------
//   <copyright file=EmployeeDto.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-04  - 4:57 PM</Date>
//   <Update> 2019-01-04 - 9:54 PM</Update>
//   -----------------------------------------------------------------------

#region

using Core.Entities;
using Crosscuting.DataTypes;

#endregion

namespace Core.DataTransferObject
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal AnnualSalary { get; set; }
        public ContractType ContractType => ContractTypeName.ToEnum(ContractType.None);
    }
}