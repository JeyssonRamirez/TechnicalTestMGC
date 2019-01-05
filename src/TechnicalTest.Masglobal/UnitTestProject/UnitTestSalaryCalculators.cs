//   -----------------------------------------------------------------------
//   <copyright file=UnitTestSalaryCalculators.cs company="Jeysson Ramirez">
//       Copyright (c) Jeysson Ramirez Todos los derechos reservados.
//   </copyright>
//   <author>Jeysson Stevens  Ramirez </author>
//   <Date>  2019 -01-05  - 12:45 AM</Date>
//   <Update> 2019-01-05 - 12:47 AM</Update>
//   -----------------------------------------------------------------------

#region

using Application.Main.Implementation.SalaryCalculator;
using Core.DataTransferObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestSalaryCalculators
    {
        //If SalaryCalculatorHourlySalary With a Employee And HourlySalary Equal 100 It Should Be 144.000
        [TestMethod]
        public void IfSalaryCalculatorHourlySalaryWithEmployeeHourlySalaryEqual100ItShouldBe144000()
        {
            // arrange
            var employee = new EmployeeDto
            {
                HourlySalary = 100,
            };
            //end result
            decimal correctResult = 144000;


            // create thing being tested with a mock dependency
            var salaryCalculator = new SalaryCalculatorHourlySalary();

            var result = salaryCalculator.CalculateSalary(employee);

            Assert.AreEqual(correctResult, result);
        }

        //If SalaryCalculatorMonthlySalary With a Employee MonthlySalary Equal 200 It Should Be 2.400
        [TestMethod]
        public void IfSalaryCalculatorMonthlySalaryWithEmployeeMonthlySalaryEqual200ItShouldBe2400()
        {
            // arrange
            var employee = new EmployeeDto
            {
                MonthlySalary = 200,
            };
            //end result
            decimal correctResult = 2400;


            // create thing being tested with a mock dependency
            var salaryCalculator = new SalaryCalculatorMonthlySalary();

            var result = salaryCalculator.CalculateSalary(employee);

            Assert.AreEqual(correctResult, result);
        }
    }
}