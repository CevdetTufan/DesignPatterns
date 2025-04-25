
/*
 * Facatory Design Pattern Dependency Injection
 * Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
 * 
 * Delegate Factory Method is a simplified version of the factory method pattern via delegate
 */

using FactoryMethodDesignPaternDI;
using FactoryMethodDesignPaternDI.Factories;
using FactoryMethodDesignPaternDI.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<ConsoleLoger>();
services.AddTransient<FileLoger>();
services.AddTransient<ILogFactory, LogFactoryService>();

services.AddTransient<Func<LogType, ILoger>>(sp => loggerType =>
{
	//var factory = sp.GetRequiredService<ILogFactory>();
	//return factory.CreateLoger(loggerType);

	//This is a simplified version of the factory method pattern via delegate
	//It allows you to create different types of loggers based on the LogType enum
	//without needing to implement a separate factory class.
	return loggerType switch
	{
		LogType.Console => sp.GetRequiredService<ConsoleLoger>(),
		LogType.File => sp.GetRequiredService<FileLoger>(),
		_ => throw new ArgumentException("Invalid log type", nameof(loggerType)),
	};
});

services.AddTransient<ReportService>();
services.AddTransient<NotificationService>();

var serviceProvider = services.BuildServiceProvider();

var reportService = serviceProvider.GetRequiredService<ReportService>();
reportService.GenerateReport("Sales");

var notificationService = serviceProvider.GetRequiredService<NotificationService>();
notificationService.Notify("This is a log message", LogType.Console);
notificationService.Notify("This is a log message", LogType.File);

Console.ReadLine();
