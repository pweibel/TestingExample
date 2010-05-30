using TaxApp.Common.Domain;
using TaxApp.Common.ServiceInterfaces;
using TaxApp.Logic.Taxes;

namespace TaxApp.Logic.Services
{
	public class TaxCalculationService : ITaxCalculationService
	{
		public decimal Calculate(Kanton kanton, Betragsart art, decimal betrag)
		{
			TaxStrategyBase strategy = TaxStrategyFactory.GetInstance().GetStrategy(kanton, art);

			return strategy.Calculate(betrag);
		}
	}
}
