using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CurrencyConverter.Api.CurrencyExchange
{
	public class CurrencyConverterApiClient : ICurrencyConverterApiClient
	{
		public CurrencyConverterApiClient(HttpClient client, IConfiguration configuration)
		{
			client.BaseAddress = new Uri(configuration.GetSection(nameof(CurrencyConverterApiClient)).Value);
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			Client = client;
		}

		private HttpClient Client { get; }

		public decimal Exchange(string from, string to, decimal value)
		{
			if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to) || value <= 0)
			{
				return 0;
			}

			var response = Client.GetAsync(string.Format(Client.BaseAddress.ToString(), from, to)).Result;

			var result = response.Content.ReadAsStringAsync().Result;

			var convertedValue = JsonConvert.DeserializeObject<JObject>(result).Values().First().Values().First().ToObject<decimal>();

			return convertedValue * value;
		}
	}
}
