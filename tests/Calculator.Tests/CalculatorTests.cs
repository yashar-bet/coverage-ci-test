using Calculator;
using Xunit;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsExpectedValue()
    {
        var calc = new CalculatorService();

        Assert.Equal(5, calc.Add(2, 3));
    }

    [Fact]
    public void Subtract_ReturnsExpectedValue()
    {
        var calc = new CalculatorService();

        Assert.Equal(1, calc.Subtract(3, 2));
    }
}