using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculator;

namespace SalaryCalculator_Tests
{
    [TestClass]
    public class SalaryCalculator_Tests
    {
        [TestMethod]
        public void GetAnnualSalary_Test()
        {
            // arrange
            Calculator sc = new Calculator();

            // act
            decimal salary = sc.GetSalary(50);

            // assert
            Assert.AreEqual(104000, salary);
        }

        [TestMethod]
        public void GetHourlyWage_Test()
        {
            // arrange
            Calculator sc = new Calculator();

            // act
            decimal hourlyWage = sc.GetHourlyWage(104000);

            // assert
            Assert.AreEqual(50, hourlyWage);

        }
    }
}
