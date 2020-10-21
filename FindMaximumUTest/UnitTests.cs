using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblem;

namespace FindMaximumUTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Given_Input_Array_Of_Values_Should_Return_The_Max_Value_Using_Generic_Class()
        {
            //Arrange
            int[] input = { 45, 389, 41 ,45,589,35};
            int expected = 589;
            GetMaximum<int> getMaxTestObj = new GetMaximum<int>(input);
            //Act
            int result = getMaxTestObj.GetMaxValue();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
