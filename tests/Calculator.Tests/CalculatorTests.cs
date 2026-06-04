using Calculator;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsExpectedValue()
    {
        var calc = new CalculatorService();

        Assert.Equal(5, calc.Add(2, 3));
    }
}