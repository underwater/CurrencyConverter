using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyConverter.Web
{
	public class Startup
	{
		public void Configure(IApplicationBuilder application, IHostingEnvironment environment)
		{
			application.UseStaticFiles();
			application.UseSpaStaticFiles();
			application.UseSpaCustom(environment);
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSpaStaticFilesCustom();
		}
	}
}
