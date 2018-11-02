using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Api.CurrencyExchange.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CurrencyExchangeController : ControllerBase
	{
		public CurrencyExchangeController(ICurrencyConverterApiClient client)
		{
			Client = client;
		}

		private ICurrencyConverterApiClient Client { get; }

		public decimal Get(string from, string to, decimal value)
		{
			return Client.Exchange(from, to, value);
		}
	}
}
