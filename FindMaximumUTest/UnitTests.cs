using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblem;

namespace FindMaximumUTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Given_Max_Value_At_First_Position_Should_Return_The_Max_Value()
        {
            //Arrange
            string expected = "Peach";
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            string result = getMaxTestObj.GetMaxValue("Peach", "Banana", "Apple");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Max_Value_At_Second_Position_Should_Return_The_Max_Value()
        {
            //Arrange
            int expected = 389;
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            int result = getMaxTestObj.GetMaxValue(45, 389, 41);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
