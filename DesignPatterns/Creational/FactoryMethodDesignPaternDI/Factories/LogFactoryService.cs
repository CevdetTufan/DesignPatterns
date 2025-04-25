using FactoryMethodDesignPaternDI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethodDesignPaternDI.Factories;

// This is a simple implementation of the ILogFactory interface that creates loggers based on the LogType enum.
public class LogFactoryService : ILogFactory
{
	private readonly IServiceProvider _serviceProvider;

	public LogFactoryService(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}
	public ILoger CreateLoger(LogType logType)
	{
		switch (logType)
		{
			case LogType.Console:
				return _serviceProvider.GetRequiredService<ConsoleLoger>();
			case LogType.File:
				return _serviceProvider.GetRequiredService<FileLoger>();
			default:
				throw new ArgumentException("Invalid log type", nameof(logType));
		}
	}
}

public enum LogType
{
	Console,
	File
}
