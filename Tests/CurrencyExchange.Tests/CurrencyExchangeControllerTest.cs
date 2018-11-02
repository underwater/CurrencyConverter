using CurrencyConverter.Api.CurrencyExchange.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverter.Api.CurrencyExchange.Tests
{
	[TestClass]
	public class CurrencyExchangeControllerTest
	{
		[TestMethod]
		public void CurrencyExchangeControllerGetWithoutParameters()
		{
			var controller = new CurrencyExchangeController(new CurrencyConverterApiClientFake());
			var result = controller.Get(string.Empty, string.Empty, 0);
			Assert.IsTrue(result == 0);
		}

		[TestMethod]
		public void CurrencyExchangeControllerGetWithParameters()
		{
			var controller = new CurrencyExchangeController(new CurrencyConverterApiClientFake());
			var result = controller.Get("USD", "BRL", 1);
			Assert.IsTrue(result > 0);
		}
	}
}
