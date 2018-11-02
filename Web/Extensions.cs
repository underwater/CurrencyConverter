using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.DependencyInjection;

namespace CurrencyConverter.Web
{
	public static class Extensions
	{
		public static void AddSpaStaticFilesCustom(this IServiceCollection services)
		{
			services.AddSpaStaticFiles(spa => spa.RootPath = "ClientApp/dist");
		}

		public static void UseSpaCustom(this IApplicationBuilder application, IHostingEnvironment environment)
		{
			application.UseSpa(spa =>
			{
				spa.Options.SourcePath = "ClientApp";

				if (environment.IsDevelopment())
				{
					spa.UseAngularCliServer("serve");
				}
			});
		}
	}
}
