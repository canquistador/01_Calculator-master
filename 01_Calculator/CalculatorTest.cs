using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod] 
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(4, Calculator.Add(2, 2));
            Assert.AreEqual(8, Calculator.Add(2, 6));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[2] {0,0};
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            //It multiplies two numbers
            Assert.AreEqual(25, Calculator.Multy(5, 5));
            //It multiplies several numbers
            int[] numbers2 = new int[5] {0,0,0,0,0};
            numbers2[0] = 5;
            numbers2[1] = 5;
            numbers2[2] = 5;
            numbers2[3] = 6;
            numbers2[4] = 2;
            Assert.AreEqual(1500, Calculator.Multy(numbers2));
            

           
        }
        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(9, Calculator.Power(3, 2));
            //It raises one number to the power of another number
        
        }
        [TestMethod]
        public void Factorial()
        {



            //# http://en.wikipedia.org/wiki/Factorial
            //  it "computes the factorial of 0"
            Assert.AreEqual(1, Calculator.Fac(0));
            //  it "computes the factorial of 1"
            Assert.AreEqual(1, Calculator.Fac(1));
            //  it "computes the factorial of 2"
            Assert.AreEqual(2, Calculator.Fac(2));
            //  it "computes the factorial of 5"
            Assert.AreEqual(120, Calculator.Fac(5));
            //  it "computes the factorial of 10"
            Assert.AreEqual(3628800, Calculator.Fac(10));
            //throw new NotImplementedException();
        }
    }
}
