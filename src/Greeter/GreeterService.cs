namespace Greeter;

public class GreeterService
{
    public string Greet(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty.", nameof(name));
        }

        return $"Hello, {name}!";
    }
}
