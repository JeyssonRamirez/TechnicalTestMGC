//   -----------------------------------------------------------------------
//   <copyright file=UnitTest1.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-05  - 12:14 AM</Date>
//   <Update> 2019-01-05 - 12:23 AM</Update>
//   -----------------------------------------------------------------------

#region

using Application.Main.Implementation;
using Core.Entities;
using IoC.DependencyInjectionFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

#endregion

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestFactory
    {
        //validate if factory return valid salary calculator
        [TestMethod]
        public void FactoryShouldReturnCalculatorForContractHourlySalaryEmployee()
        {
            // arrange
            var typeContract = ContractType.HourlySalaryEmployee;


            var factory = Factory.Resolve<IFactorySalaryCalculator>();
            // act
            var calculator = factory.GetCalculator(typeContract);
            ContractType currentContract = calculator.ContractType;
            // assert
            Assert.AreEqual(typeContract, currentContract);
        }
        //validate if factory return valid salary calculator
        [TestMethod]
        public void FactoryShouldReturnCalculatorForContractMonthlySalaryEmployee()
        {
            // arrange
            var typeContract = ContractType.MonthlySalaryEmployee;


            var factory = Factory.Resolve<IFactorySalaryCalculator>();
            // act
            var calculator = factory.GetCalculator(typeContract);
            ContractType currentContract = calculator.ContractType;
            // assert
            Assert.AreEqual(typeContract, currentContract);
        }
    }
}