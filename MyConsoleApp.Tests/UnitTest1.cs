using MyConsoleApp;
using Xunit;

namespace MyConsoleApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsSum()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 1, 0)]
    [InlineData(100, 200, 300)]
    public void Add_VariousInputs_ReturnsCorrectSum(int a, int b, int expected)
    {
        // Arrange & Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
    }
}
