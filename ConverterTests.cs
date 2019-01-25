using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralConverter.UnitTests
{
    [TestClass]
    public class ConverterTests
    {
        // [TestMethod]
        // public void TestReturnTypeIsInitializedToZero()
        // {
        //    // Arrange
        //    Converter convert = new Converter();

        //    //Act
        //    int result = convert.RomanToInt("");

        //    // Assert
        //    Assert.AreEqual(0, result);
        // }

        [TestMethod]
        public void TestForRandomInputs()
        {
            Converter convert = new Converter();
            Random rand = new Random();
            int input = rand.Next(1, 3999);

            int result1 = convert.RomanToInt("MMDCCCLXXXVIII");
            int result2 = convert.RomanToInt("MMDCXIX");
            int result3 = convert.RomanToInt("MCCXCIV");
            int result4 = convert.RomanToInt("MMMDCCCLII");

            Assert.AreEqual(2888, result1);
            Assert.AreEqual(2619, result2);
            Assert.AreEqual(1294, result3);
            Assert.AreEqual(3852, result4);

        }
    }
}
