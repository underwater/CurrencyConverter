using System.Linq;
using CurrencyConverter.Api.CurrencyList.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverter.Api.CurrencyList.Tests
{
	[TestClass]
	public class CurrencyListControllerTest
	{
		[TestMethod]
		public void CurrencyListControllerTestGetEmpty()
		{
			var controller = new CurrencyListController(new CurrencyConverterApiClientEmptyFake());
			var result = controller.Get();
			Assert.IsFalse(result.Any());
		}

		[TestMethod]
		public void CurrencyListControllerTestGetNotEmpty()
		{
			var controller = new CurrencyListController(new CurrencyConverterApiClientNotEmptyFake());
			var result = controller.Get();
			Assert.IsTrue(result.Any());
		}
	}
}
