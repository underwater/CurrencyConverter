using System.Collections.Generic;

namespace CurrencyConverter.Api.CurrencyList.Tests
{
	public class CurrencyConverterApiClientNotEmptyFake : ICurrencyConverterApiClient
	{
		public IEnumerable<Currency> List()
		{
			yield return new Currency { Id = "BRL", Name = "Brazilian Real", Symbol = "R$" };
			yield return new Currency { Id = "USD", Name = "United States Dollar", Symbol = "$" };
		}
	}
}
