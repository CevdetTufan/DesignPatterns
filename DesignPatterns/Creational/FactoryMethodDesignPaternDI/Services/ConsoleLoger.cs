namespace FactoryMethodDesignPaternDI.Services;
public class ConsoleLoger: ILoger
{
	public void Log(string message)
	{
		Console.WriteLine($"Writing to console: {message}");
	}
}

