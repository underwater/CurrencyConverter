using System.Collections.Generic;

namespace CurrencyConverter.Api.CurrencyList
{
	public interface ICurrencyConverterApiClient
	{
		IEnumerable<Currency> List();
	}
}
