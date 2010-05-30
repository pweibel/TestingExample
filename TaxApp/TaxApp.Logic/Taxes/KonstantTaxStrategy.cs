using System;
using TaxApp.Common.Domain;

namespace TaxApp.Logic.Taxes
{
	public class KonstantTaxStrategy : TaxStrategyBase
	{
		public KonstantTaxStrategy(TaxConfiguration configuration) : base(configuration)
		{
		}

		public override Strategieart Strategieart
		{
			get { return Strategieart.Konstant; }
		}

		public override decimal Calculate(decimal betrag)
		{
			if(this.Configuration == null) throw new Exception("No Taxconfiguration available.");

			return Math.Round(betrag * this.Configuration.Tarif, MidpointRounding.AwayFromZero);
		}
	}
}
