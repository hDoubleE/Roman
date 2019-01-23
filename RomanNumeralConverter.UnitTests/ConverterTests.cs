using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralConverter.UnitTests
{
    [TestClass]
    public class ConverterTests
    {
        //[TestMethod]
        //public void TestReturnTypeIsInitializedToZero()
        //{
        //    // Arrange
        //    Converter convert = new Converter();
        //    //Act
        //    int result = convert.RomanToInt("");
        //    // Assert
        //    Assert.AreEqual(0, result);
        //}
        [TestMethod]
        public void TestForRandomInputs()
        {
            Converter convert = new Converter();
            Random rand = new Random();
            int input = rand.Next(1, 3999);
            // Input must be between 1 and 3999

            int result1 = convert.RomanToInt("MMDCCCLXXXVIII");
            int result2 = convert.RomanToInt("MMDCXIX");
            int result3 = convert.RomanToInt("MCCXCIV");
            int result4 = convert.RomanToInt("MMMDCCCLII");
            //int result5 = convert.RomanToInt("MMMCMXCIX");
            //int result6 = convert.RomanToInt("1234");
            //int result7 = convert.RomanToInt("");


            Assert.AreEqual(2888, result1);
            Assert.AreEqual(2619, result2);
            Assert.AreEqual(1294, result3);
            Assert.AreEqual(3852, result4);
            //Assert.AreEqual(2888, result5);
            //Assert.AreEqual(2888, result6);
            //Assert.AreEqual(2888, result7);

        }

        //[TestMethod]
        //public void TestRandomNumeralInputs()
        //{
        //    Converter convert = new Converter();

        //    var chars = "MCDLXVI";
        //    var stringChars = new char[10];
        //    var random = new Random();

        //    for (int i = 0; i<stringChars.Length; i++)
        //    {
        //        stringChars[i] = chars[random.Next(chars.Length)];
        //    }

        //    var input = new String(stringChars);
        //    int result = convert.RomanToInt(input);


        //    Assert.AreEqual(convert.RomanToInt(input), input);
        //}
    }
}
