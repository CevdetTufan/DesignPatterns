using FactoryMethodDesignPaternDI.Factories;

namespace FactoryMethodDesignPaternDI;
public class ReportService
{
	private readonly ILogFactory _logFactory;

	public ReportService(ILogFactory logFactory)
	{
		_logFactory = logFactory;
	}

	public void GenerateReport(string reportType)
	{
		var loger = _logFactory.CreateLoger(LogType.Console);
		loger.Log($"Generating {reportType} report...");
	}
}
