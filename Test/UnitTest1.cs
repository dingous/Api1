using Api.Controllers;
using Api1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestarTaxaFixa()
		{
			var obj = new Api1Controller();
			var Taxa = obj.Get();

			Assert.AreEqual(Taxa, Util.TaxaJuros);
		}
	}
}
