using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CountName_Calc_Res
    {
        [TestMethod]
        public void TestMuti()
        {
            // Arrange
            Calc calc = new Calc();

            // Act
            float res = calc.CountNum("1", "3", "*");

            // Assert
            Assert.AreEqual(3, res); //проверка правильности умножения
        }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            Calc calc = new Calc();

            // Act
            float res = calc.CountNum("6", "0", "/");

            // Assert
            //Assert.AreEqual(3, res); //проверка правильности умножения
            Assert.IsTrue(res != 0); //проверка деления на ноль
        }

        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            Calc calc = new Calc();

            // Act
            float res = calc.CountNum("1", "1", "+");

            // Assert
            Assert.AreEqual(2, res);  //проверка правильности умножения
        }

        [TestMethod]
        public void TestSub()
        {
            // Arrange
            Calc calc = new Calc();

            // Act
            float res = calc.CountNum("6", "3", "-");

            // Assert
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void Test()
        { 
            // Arrange
            Calc calc = new Calc();

            // Act
            float res = calc.CountNum("6", "3", "-");

            // Assert
            Assert.AreEqual(3, res);
        }
    }

    [TestClass]
    public class CountName_Calc_Res2
    {
        [TestMethod]
        public void Test()
        {
            //float res = Calc.CountNum("6", "3", "-");
            //Assert.AreEqual(3, res);
        }
    }




}
