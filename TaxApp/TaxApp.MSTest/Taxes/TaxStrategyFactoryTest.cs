using Microsoft.VisualStudio.TestTools.UnitTesting;

using TaxApp.Common.RepositoryInterfaces;
using TaxApp.Data.Repositories;
using TaxApp.Logic.Taxes;

namespace TaxApp.MSTest.Taxes
{
 	[TestClass]
	public class TaxStrategyFactoryTest
	{
		[TestMethod]
		public void GetInstanceTest_with_custom_repository()
		{
			// Arrange
			ITaxConfigurationRepository configurationRepository = new TaxConfigurationRepository();
			
			// Act
			TaxStrategyFactory actual = TaxStrategyFactory.GetInstance(configurationRepository);
			TaxStrategyFactory actual2 = TaxStrategyFactory.GetInstance();

			// Assert
			Assert.AreSame(actual, actual2);
		}

		[TestMethod]
		public void GetInstanceTest_with_default_repository()
		{
			// Arrange
			// Nothing to do
			
			// Act
			TaxStrategyFactory actual = TaxStrategyFactory.GetInstance();
			TaxStrategyFactory actual2 = TaxStrategyFactory.GetInstance();

			// Assert
			Assert.AreSame(actual, actual2);
		}
	}
}
