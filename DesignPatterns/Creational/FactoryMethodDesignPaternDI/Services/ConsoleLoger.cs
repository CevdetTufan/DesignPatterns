namespace FactoryMethodDesignPaternDI.Services;

// This is a simple implementation of the ILoger interface that writes log messages to the console.
public class ConsoleLoger: ILoger
{
	public void Log(string message)
	{
		Console.WriteLine($"Writing to console: {message}");
	}
}

