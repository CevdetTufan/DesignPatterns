

LogFactory factory = new ConsoleLogFactory();
ILoger loger = factory.CreateLogger();
loger.Log("This is a log message.");


public interface ILoger
{
	void Log(string message);
}

public class ConsoleLogger : ILoger
{
	public void Log(string message)
	{
		Console.WriteLine(message);
	}
}

public class FileLogger : ILoger
{
	public void Log(string message)
	{
		File.AppendAllText("log.txt", message + Environment.NewLine);
	}
}

public abstract class LogFactory
{
	public abstract ILoger CreateLogger();
}

public class ConsoleLogFactory : LogFactory
{
	public override ILoger CreateLogger()
	{
		return new ConsoleLogger();
	}
}

public class FileLogFactory : LogFactory
{
	public override ILoger CreateLogger()
	{
		return new FileLogger();
	}
}
