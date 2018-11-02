namespace CurrencyConverter.Api.CurrencyExchange
{
	public interface ICurrencyConverterApiClient
	{
		decimal Exchange(string from, string to, decimal value);
	}
}
