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
	var factory = sp.GetRequiredService<ILogFactory>();
	return factory.CreateLoger(loggerType);
});

services.AddTransient<ReportService>();
services.AddTransient<NotificationService>();

var serviceProvider = services.BuildServiceProvider();

var reportService = serviceProvider.GetRequiredService<ReportService>();
reportService.GenerateReport("Sales");

var notificationService = serviceProvider.GetRequiredService<NotificationService>();
notificationService.Notify("This is a log message", LogType.File);

Console.ReadLine();
