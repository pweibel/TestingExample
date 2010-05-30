using System.Collections.Generic;
using TaxApp.Common.Domain;

namespace TaxApp.Common.RepositoryInterfaces
{
	public interface ITaxConfigurationRepository
	{
		IList<TaxConfiguration> FindByKantonAndBetragsart(Kanton kanton, Betragsart betragsart);

		void SaveAndUpdateTaxConfiguration(TaxConfiguration configuration);
		void RemoveTaxConfiguration(TaxConfiguration configuration);
	}
}
