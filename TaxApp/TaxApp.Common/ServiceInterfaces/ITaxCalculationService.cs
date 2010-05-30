using TaxApp.Common.Domain;

namespace TaxApp.Common.ServiceInterfaces
{
	public interface ITaxCalculationService
	{
		decimal Calculate(Kanton kanton, Betragsart art, decimal betrag);
	}
}
