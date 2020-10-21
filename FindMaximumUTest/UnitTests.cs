using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblem;

namespace FindMaximumUTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Given_Max_Value_At_Fiirst_Position_Should_Return_The_Max_Value()
        {
            //Arrange
            string expected = "Peach";
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            string result = getMaxTestObj.GetMaxValue("Peach", "Banana", "Apple");
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
