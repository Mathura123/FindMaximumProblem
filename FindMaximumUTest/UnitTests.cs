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
        [TestMethod]
        public void Given_Max_Number_At_Third_Position_Should_Return_The_Max_No()
        {
            //Arrange
            int expected = 90;
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            int result = getMaxTestObj.GetMaxInt(9, 80, 90);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Max_Float_No_At_First_Position_Should_Return_The_Max_No()
        {
            //Arrange
            double expected = 90.45;
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            double result = getMaxTestObj.GetMaxFloat(90.45, 90.1, 80.45);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Max_Float_No_At_Second_Position_Should_Return_The_Max_No()
        {
            //Arrange
            double expected = 100.485;
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            double result = getMaxTestObj.GetMaxFloat(90.45, 100.485, 80.45);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Max_Float_No_At_Third_Position_Should_Return_The_Max_No()
        {
            //Arrange
            double expected = 150.455;
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            double result = getMaxTestObj.GetMaxFloat(90.45, 90.1, 150.455);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Max_String_At_First_Position_Should_Return_The_Max_String()
        {
            //Arrange
            string expected = "Peach";
            GetMaximum getMaxTestObj = new GetMaximum();
            //Act
            string result = getMaxTestObj.GetMaxString("Peach", "Banana", "Apple");
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
