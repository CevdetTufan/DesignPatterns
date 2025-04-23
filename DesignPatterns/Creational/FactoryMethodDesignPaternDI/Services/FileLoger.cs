namespace FactoryMethodDesignPaternDI.Services;
public class FileLoger : ILoger
{
	public void Log(string message)
	{
		// Simulate writing to a file
		Console.WriteLine($"Writing to file: {message}");
	}
}
