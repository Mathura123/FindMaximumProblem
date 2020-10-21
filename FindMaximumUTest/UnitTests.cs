using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblem;

namespace FindMaximumUTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Given_Max_Number_At_First_Position_Should_Return_The_Max_No()
        {
            //Arrange
            int expected = 90;
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            int result = getMaxTestObj.GetMaxInt(90, 8, 45);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Max_Number_At_Second_Position_Should_Return_The_Max_No()
        {
            //Arrange
            int expected = 90;
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            int result = getMaxTestObj.GetMaxInt(5, 90, 45);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
