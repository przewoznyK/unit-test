using Xunit;
using Testy.Console;
using System;

namespace TestProject1.Console.Test
{
    public class UnitTest1
    {
        Calculator calculator = new Calculator();
        [Fact]
        public void Add()
        {
            // Arrange
            float a = 8;
            float b = 4;
            // Act
            float result = calculator.Add(a, b);
            // Assert
            Assert.Equal(result, 12);
        }
        [Fact]
        public void Substract()
        {
            // Arrange
            float a = 8;
            float b = 4;
            // Act
            float result = calculator.Subtract(a, b);
            // Assert
            Assert.Equal(result, 4);
        }
        [Fact]
        public void Multiply()
        {
            // Arrange
            float a = 8;
            float b = 4;
            // Act
            float result = calculator.Multiply(a, b);
            // Assert
            Assert.Equal(result, 32);
        }
        [Fact]
        public void Divide()
        {
            // Arrange
            float a = 8;
            float b = 4;
            // Act
            float result = calculator.Divide(a, b);
            // Assert
            Assert.Equal(result, 2);
        }
        [Fact]
        public void Divide_DivisionByZero()
        {
            // Arrange
            float a = 8;
            float b = 0;

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }
    }
}