using FlexMath.Core;
using Moq;

namespace FlexMath.Tests.Unit
{
    public class FlexCalculatorTests
    {
        private readonly FlexCalculator _calculator;
        private readonly Mock<IStringToNumberConvertor> _stringToNumberConvertorMock;

        public FlexCalculatorTests()
        {
            _stringToNumberConvertorMock = new Mock<IStringToNumberConvertor>();
            _stringToNumberConvertorMock.Setup(x => x.Convert("One")).Returns(1);
            _stringToNumberConvertorMock.Setup(x => x.Convert("Two")).Returns(2);
            _stringToNumberConvertorMock.Setup(x => x.Convert("Three")).Returns(3);
            _stringToNumberConvertorMock.Setup(x => x.Convert("Four")).Returns(4);
            _calculator = new FlexCalculator(_stringToNumberConvertorMock.Object);
        }

        [Fact]
        public void Should_Add_TwoNumbers()
        {
            // Arrange
            var left = 1;
            var right = 2;
            var expectedResult = 3;

            // Act
            var result = _calculator.Add(left, right);

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
            var result = _calculator.Add(left, right);

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
            var result = _calculator.Add(left, right);

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
            var result = _calculator.Add(left, right);

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
            var result = _calculator.Subtract(left, right);

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
            var result = _calculator.Subtract(left, right);

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
            var result = _calculator.Subtract(left, right);

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
            var result = _calculator.Subtract(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Substract_NumberAsEnglishWord_And_Number()
        {
            // Arrange
            var left = "One";
            var right = 2;
            var expectedResult = -1;

            // Act
            var result = _calculator.Subtract(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("Two", "One", 1)]
        [InlineData("Four", "1", 3)]
        [InlineData("2", "9", -7)]
        [InlineData("20", "One", 19)]
        public void Should_Substract_TwoStrings(string left, string right, double expectedResult)
        {
            // Act
            var result = _calculator.Subtract(left, right);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}