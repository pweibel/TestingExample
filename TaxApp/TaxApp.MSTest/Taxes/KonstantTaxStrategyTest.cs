using Microsoft.VisualStudio.TestTools.UnitTesting;

using TaxApp.Common.Domain;
using TaxApp.Logic.Taxes;

namespace TaxApp.MSTest.Taxes
{
	[TestClass]
	public class KonstantTaxStrategyTest
	{
		[TestMethod]
		public void KonstantTaxStrategyConstructorTest()
		{
			// Arrange
			TaxConfiguration configuration = new TaxConfiguration { 
					Kanton = Kanton.Bern, 
					Betragsart = Betragsart.Rente, 
					Tarif = 0.1m, 
					Strategieart = Strategieart.Konstant
			};

			// Act
			KonstantTaxStrategy strategy = new KonstantTaxStrategy(configuration);
			
			// Assert
			Assert.AreSame(configuration, strategy.Configuration);
		}

		[TestMethod]
		public void CalculateTest()
		{
			// Arrange
			TaxConfiguration configuration = new TaxConfiguration
			{
				Kanton = Kanton.Bern,
				Betragsart = Betragsart.Rente,
				Tarif = 0.1m,
				Strategieart = Strategieart.Konstant
			};
			KonstantTaxStrategy strategy = new KonstantTaxStrategy(configuration);
			decimal betrag = 100m;
			decimal expected = 10m;

			// Act
			decimal actual = strategy.Calculate(betrag);
			
			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StrategieartTest()
		{
			// Arrange
			TaxConfiguration configuration = null;
			KonstantTaxStrategy strategy = new KonstantTaxStrategy(configuration);

			// Act
			// Noting to do

			// Assert
			Assert.AreEqual(Strategieart.Konstant, strategy.Strategieart);
		}
	}
}
