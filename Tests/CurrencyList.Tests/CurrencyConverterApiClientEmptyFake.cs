using System.Collections.Generic;

namespace CurrencyConverter.Api.CurrencyList.Tests
{
	public class CurrencyConverterApiClientEmptyFake : ICurrencyConverterApiClient
	{
		public IEnumerable<Currency> List()
		{
			return new List<Currency>();
		}
	}
}
