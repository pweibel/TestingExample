using System;
using TaxApp.Common.Domain;
using System.Linq;

namespace TaxApp.Logic.Taxes
{
	public class TranchenTaxStrategy : TaxStrategyBase
	{
		public TranchenTaxStrategy(TaxConfiguration configuration) : base(configuration)
		{
		}

		public override Strategieart Strategieart
		{
			get { return Strategieart.Tranchen; }
		}

		public override decimal Calculate(decimal betrag)
		{
			if(this.Configuration == null) throw new Exception("No Taxconfiguration available.");

			decimal mTax = 0;

			var query = from t in this.Configuration.Tranchen
						orderby t.BetragVon ascending 
			            select t;
						
			foreach(TaxTranche tranche in query)
			{
				if(betrag >= tranche.BetragVon)
				{
					// Rechnen mit Absolutwerten
					decimal mTranchenMin = tranche.BetragVon;
					decimal mTranchenMax;
					if(tranche.BetragBis == null || betrag <= tranche.BetragBis)
					{
						mTranchenMax = betrag;
					}
					else
					{
						mTranchenMax = tranche.BetragBis.Value;
					}
					decimal mBetragTranche = mTranchenMax - mTranchenMin;
					decimal mSteuerBetragDetail = Math.Round(mBetragTranche * tranche.Tarif, MidpointRounding.AwayFromZero);
					mTax += mSteuerBetragDetail;
				}
			}

			return mTax;
		}
	}
}
