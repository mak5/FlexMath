using FlexMath.Core;

namespace FlexMath.Tests.Unit
{
    public class FlexCalculatorTests
    {
        [Fact]
        public void Should_Add_TwoNumbers()
        {
            // Arrange
            var left = 1;
            var right = 2;
            var expectedResult = 3;

            // Act
            var result = FlexCalculator.Add(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Add_Number_And_NumberAsString()
        {
            // Arrange
            var left = 1;
            var right = "2";
            var expectedResult = 3;

            // Act
            var result = FlexCalculator.Add(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Add_Number_And_NumberAsEnglishWord()
        {
            // Arrange
            var left = 1;
            var right = "Two";
            var expectedResult = 3;

            // Act
            var result = FlexCalculator.Add(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("Two", "One", 3)]
        [InlineData("Four", "1", 5)]
        [InlineData("2", "9", 11)]
        [InlineData("20", "One", 21)]
        public void Should_Add_TwoStrings(string left, string right, double expectedResult)
        {
            // Act
            var result = FlexCalculator.Add(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Substract_TwoNumbers()
        {
            // Arrange
            var left = 6;
            var right = 2;
            var expectedResult = 4;

            // Act
            var result = FlexCalculator.Subtract(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Substract_Number_And_NumberAsString()
        {
            // Arrange
            var left = 6;
            var right = "2";
            var expectedResult = 4;

            // Act
            var result = FlexCalculator.Subtract(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Substract_NumberAsString_And_Number()
        {
            // Arrange
            var left = "6";
            var right = 2;
            var expectedResult = 4;

            // Act
            var result = FlexCalculator.Subtract(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Substract_Number_And_NumberAsEnglishWord()
        {
            // Arrange
            var left = 6;
            var right = "Two";
            var expectedResult = 4;

            // Act
            var result = FlexCalculator.Subtract(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Substract_NumberAsEnglishWord_And_Number()
        {
            // Arrange
            var left = "Six";
            var right = 2;
            var expectedResult = 4;

            // Act
            var result = FlexCalculator.Subtract(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}