using TaxApp.Logic.Taxes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxApp.Common.RepositoryInterfaces;

namespace TaxApp.MSTest
{
 	[TestClass()]
	public class TaxStrategyFactoryTest
	{
		[TestMethod()]
		public void GetInstanceTest()
		{
			ITaxConfigurationRepository configurationRepository = null; // TODO: Initialize to an appropriate value
			TaxStrategyFactory expected = null; // TODO: Initialize to an appropriate value
			TaxStrategyFactory actual;
			actual = TaxStrategyFactory.GetInstance(configurationRepository);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void GetInstanceTest1()
		{
			TaxStrategyFactory expected = null; // TODO: Initialize to an appropriate value
			TaxStrategyFactory actual;
			actual = TaxStrategyFactory.GetInstance();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
