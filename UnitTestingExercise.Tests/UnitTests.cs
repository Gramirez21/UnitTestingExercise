using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var test = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,0)]//Add test data <-------
        [InlineData(2,1,1)]
        [InlineData(3,1,2)]

        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var testMinus = new Calculator();

            //Act

            var actualMinus = testMinus.Minus(minuend, subtrhend);

            //Assert

            Assert.Equal(expected, actualMinus);
        }

        [Theory]
        [InlineData(1,1,1)]//Add test data <-------
        [InlineData(3,3,9)]
        [InlineData(5,5,25)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var test = new Calculator();

            //Act

            var actualTimes = test.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actualTimes);

        }

        [Theory]
        [InlineData(9,3,3)]//Add test data <-------
        [InlineData(45,5,9)]
        [InlineData(12,4,3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var actual = new Calculator();  

            //Act

            var actualDivide = actual.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actualDivide);

        }

    }
}
