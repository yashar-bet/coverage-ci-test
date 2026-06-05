using Greeter;
using Xunit;

namespace Greeter.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_ReturnsExpectedMessage()
    {
        var greeter = new GreeterService();

        Assert.Equal("Hello, Alice!", greeter.Greet("Alice"));
    }

    [Fact]
    public void Greet_EmptyName_Throws()
    {
        var greeter = new GreeterService();

        Assert.Throws<ArgumentException>(() => greeter.Greet(""));
    }
}
