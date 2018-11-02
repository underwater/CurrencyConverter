using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Api.CurrencyList.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CurrencyListController : ControllerBase
	{
		public CurrencyListController(ICurrencyConverterApiClient client)
		{
			Client = client;
		}

		private ICurrencyConverterApiClient Client { get; }

		public IEnumerable<Currency> Get()
		{
			return Client.List();
		}
	}
}
