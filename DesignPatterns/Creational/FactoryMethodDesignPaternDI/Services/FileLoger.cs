namespace FactoryMethodDesignPaternDI.Services;

// This is a simple implementation of the ILoger interface that writes log messages to a file.
public class FileLoger : ILoger
{
	public void Log(string message)
	{
		// Simulate writing to a file
		Console.WriteLine($"Writing to file: {message}");
	}
}
