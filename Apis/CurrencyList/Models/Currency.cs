using Newtonsoft.Json;

namespace CurrencyConverter.Api.CurrencyList
{
	public class Currency
	{
		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "currencyName")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "currencySymbol")]
		public string Symbol { get; set; }
	}
}
