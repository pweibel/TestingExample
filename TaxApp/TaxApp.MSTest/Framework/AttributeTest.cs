using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxApp.MSTest.Framework
{
	[TestClass]
	public class AttributeTest
	{
		/// <summary>
		/// Gets or sets the test context which provides
		/// information about and functionality for the current test run.
		/// </summary>
		public TestContext TestContext { get; set; }

		#region Additional test attributes
		[ClassInitialize]
		public static void MyClassInitialize(TestContext testContext)
		{
			Console.WriteLine("ClassInitialize called with context: " + testContext);
		}

		[ClassCleanup]
		public static void MyClassCleanup()
		{
			Console.WriteLine("ClassCleanup called.");
		}

		[TestInitialize]
		public void MyTestInitialize()
		{
			Console.WriteLine("TestInitialize called.");
		}

		[TestCleanup]
		public void MyTestCleanup()
		{
			Console.WriteLine("TestCleanup called.");
		}
		#endregion

		[TestMethod, Ignore]
		public void TestIgnoreAttribute()
		{
			// Empty body	
		}

		[TestMethod, Owner("Patrick Weibel")]
		public void TestOwnerAttribute()
		{
			// Empty body
		}

		[TestMethod, Description("This is a simple unit test.")]
		public void TestDescriptionAttribute()
		{
			// Arrange
			int a = 3;

			// Act
			int b = 6 - 3;

			// Assert
			Assert.AreEqual(a, b);
		}

		[TestMethod, TestCategory("Simple tests")]
		public void TestCategoryAttribute()
		{
			// Arrange
			int a = 5;

			// Act
			int b = 2 + 3;

			// Assert
			Assert.AreEqual(a, b);
		}
	}
}
