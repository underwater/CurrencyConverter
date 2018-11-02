using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyConverter.Api.CurrencyList
{
	public class Startup
	{
		public void Configure(IApplicationBuilder application)
		{
			application.UseCorsCustom();
			application.UseHttpsRedirection();
			application.UseMvcWithDefaultRoute();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddCors();
			services.AddMvcCustom();
			services.AddHttpClientCustom();
		}
	}
}
