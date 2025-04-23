using FactoryMethodDesignPaternDI.Factories;
using FactoryMethodDesignPaternDI.Services;

namespace FactoryMethodDesignPaternDI;
public class NotificationService
{
	private readonly Func<LogType, ILoger> _loger;

	public NotificationService(Func<LogType, ILoger> loger)
	{
		_loger = loger;
	}

	public void Notify(string message, LogType logType)
	{
		var loger = _loger(logType);
		loger.Log(message);
	}
}
