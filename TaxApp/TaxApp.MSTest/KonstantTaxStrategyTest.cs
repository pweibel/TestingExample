using TaxApp.Logic.Taxes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaxApp.Common.Domain;

namespace TaxApp.MSTest
{
	[TestClass()]
	public class KonstantTaxStrategyTest
	{
		[TestMethod()]
		public void KonstantTaxStrategyConstructorTest()
		{
			TaxConfiguration configuration = null; // TODO: Initialize to an appropriate value
			KonstantTaxStrategy target = new KonstantTaxStrategy(configuration);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		[TestMethod()]
		public void CalculateTest()
		{
			TaxConfiguration configuration = null; // TODO: Initialize to an appropriate value
			KonstantTaxStrategy target = new KonstantTaxStrategy(configuration); // TODO: Initialize to an appropriate value
			Decimal betrag = new Decimal(); // TODO: Initialize to an appropriate value
			Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
			Decimal actual;
			actual = target.Calculate(betrag);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		[TestMethod()]
		public void StrategieartTest()
		{
			TaxConfiguration configuration = null; // TODO: Initialize to an appropriate value
			KonstantTaxStrategy target = new KonstantTaxStrategy(configuration); // TODO: Initialize to an appropriate value
			Strategieart actual;
			actual = target.Strategieart;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
