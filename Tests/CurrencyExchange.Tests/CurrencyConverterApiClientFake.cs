namespace CurrencyConverter.Api.CurrencyExchange.Tests
{
	public class CurrencyConverterApiClientFake : ICurrencyConverterApiClient
	{
		public decimal Exchange(string from, string to, decimal value)
		{
			if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to) || value <= 0)
			{
				return 0;
			}

			return value;
		}
	}
}
