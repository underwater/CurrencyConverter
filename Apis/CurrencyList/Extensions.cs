using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace CurrencyConverter.Api.CurrencyList
{
	public static class Extensions
	{
		public static void AddHttpClientCustom(this IServiceCollection services)
		{
			services.AddHttpClient<ICurrencyConverterApiClient, CurrencyConverterApiClient>();
		}

		public static void AddMvcCustom(this IServiceCollection services)
		{
			services.AddMvc().AddJsonOptions(json => json.SerializerSettings.NullValueHandling = NullValueHandling.Ignore);
		}

		public static void UseCorsCustom(this IApplicationBuilder application)
		{
			application.UseCors(cors => cors.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().AllowCredentials());
		}
	}
}
