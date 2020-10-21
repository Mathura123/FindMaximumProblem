using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblem;

namespace FindMaximumUTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Given_Max_Value_At_First_Position_Should_Return_The_Max_Value_Using_Generic_Class()
        {
            //Arrange
            string[] input = { "Peach", "Banana", "Apple","Orange"};
            string expected = "Peach";
            GetMaximum<string> getMaxTestObj = new GetMaximum<string>(input);
            //Act
            string result = getMaxTestObj.GetMaxValue();
            //Assert
            Assert.AreEqual(expected, result);
        }
        //[TestMethod]
        //public void Given_Max_Value_At_Second_Position_Should_Return_The_Max_Value_Using_Generic_Class()
        //{
        //    //Arrange
        //    int expected = 389;
        //    GetMaximum<int> getMaxTestObj = new GetMaximum<int>(45, 389, 41);
        //    //Act
        //    int result = getMaxTestObj.GetMaxValue();
        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}
        //[TestMethod]
        //public void Given_Max_Value_At_Third_Position_Should_Return_The_Max_Value_Using_Generic_Class()
        //{
        //    //Arrange
        //    double expected = 145.01;
        //    GetMaximum<double> getMaxTestObj = new GetMaximum<double>(45.12, 7.152, 145.01);
        //    //Act
        //    double result = getMaxTestObj.GetMaxValue();
        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}
    }
}
