using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.Tests
{
    [TestClass()]
    public class BMICalculatorTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            //Arrange
            BMICalculator bc = new BMICalculator();
            //act
            double bmi = bc.Calculate(80.0, 180);

            double expected = 80.0/((180/100.0)*(180/100.0));

            Assert.AreEqual(expected, bmi);
        }
    }
}