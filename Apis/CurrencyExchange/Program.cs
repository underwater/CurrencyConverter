using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CurrencyConverter.Api.CurrencyExchange
{
	public static class Program
	{
		public static void Main()
		{
			WebHost.CreateDefaultBuilder().UseStartup<Startup>().Build().Run();
		}
	}
}
