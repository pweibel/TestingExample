using TaxApp.Logic.Taxes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaxApp.Common.Domain;

namespace TaxApp.MSTest
{
	[TestClass()]
	public class TranchenTaxStrategyTest
	{
		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion

		[TestMethod()]
		public void TranchenTaxStrategyConstructorTest()
		{
			TaxConfiguration configuration = null; // TODO: Initialize to an appropriate value
			TranchenTaxStrategy target = new TranchenTaxStrategy(configuration);
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		[TestMethod()]
		public void CalculateTest()
		{
			TaxConfiguration configuration = null; // TODO: Initialize to an appropriate value
			TranchenTaxStrategy target = new TranchenTaxStrategy(configuration); // TODO: Initialize to an appropriate value
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
			TranchenTaxStrategy target = new TranchenTaxStrategy(configuration); // TODO: Initialize to an appropriate value
			Strategieart actual;
			actual = target.Strategieart;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
