using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TaxApp.Common.Domain;
using TaxApp.Logic.Taxes;

namespace TaxApp.MSTest.Taxes
{
	[TestClass]
	public class TranchenTaxStrategyTest
	{
		[TestMethod]
		public void TranchenTaxStrategyConstructorTest()
		{
			// Arrange
			TaxConfiguration configuration = new TaxConfiguration { 
				Betragsart = Betragsart.Rente,
				Kanton = Kanton.Bern,
				Strategieart = Strategieart.Tranchen,
				Tarif = 0m
				};
			
			// Act
			TranchenTaxStrategy strategy = new TranchenTaxStrategy(configuration);
			
			// Assert
			Assert.AreSame(configuration, strategy.Configuration);
		}

		[TestMethod]
		public void CalculateTest()
		{
			// Arrange
			TaxConfiguration configuration = new TaxConfiguration
			{
				Betragsart = Betragsart.Rente,
				Kanton = Kanton.Bern,
				Strategieart = Strategieart.Tranchen,
				Tarif = 0,
				Tranchen = new List<TaxTranche> { 
					new TaxTranche { BetragVon = 0, BetragBis = 50, Tarif = 0.05m },
					new TaxTranche { BetragVon = 50, Tarif = 0.1m }
				}
			};
			TranchenTaxStrategy strategy = new TranchenTaxStrategy(configuration);
			decimal betrag = 100;
			decimal expected = 7.5m;

			// Act
			decimal actual = strategy.Calculate(betrag);

			// Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StrategieartTest()
		{
			// Arrange
			TranchenTaxStrategy strategy = new TranchenTaxStrategy(null);

			// Act
			// Nothing to do

			// Assert
			Assert.AreEqual(Strategieart.Tranchen, strategy.Strategieart);
		}
	}
}
