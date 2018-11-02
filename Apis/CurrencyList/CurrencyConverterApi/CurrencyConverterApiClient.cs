using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CurrencyConverter.Api.CurrencyList
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

		public IEnumerable<Currency> List()
		{
			var response = Client.GetAsync(Client.BaseAddress).Result;

			var results = response.Content.ReadAsStringAsync().Result;

			return JsonConvert
				.DeserializeObject<JObject>(results)
				.GetValue(nameof(results))
				.Values()
				.Select(x => x.ToObject<Currency>())
				.OrderBy(x => x.Name);
		}
	}
}
