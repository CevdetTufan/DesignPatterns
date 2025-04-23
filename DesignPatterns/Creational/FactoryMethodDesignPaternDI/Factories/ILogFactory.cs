using FactoryMethodDesignPaternDI.Services;

namespace FactoryMethodDesignPaternDI.Factories;
public interface ILogFactory
{
	ILoger CreateLoger(LogType logType);
}
